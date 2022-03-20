using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;



namespace resurce_packer
{

    public partial class Form1 : Form
    {
        List<resItem> resCollection = new List<resItem>();
        int selectedIndex; //Текущий выбранный индекс
        UInt32 start_adress = 0x0800C000;





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resCollection.Add(new resItem() { id = 10, name = "+", start_adress = 0x80000 });
            Collection_to_list();
        }

        //Открытите
        private void Form1_Shown(object sender, EventArgs e)
        {

            string jsonString = File.ReadAllText("resCollection.json");

            resCollection = JsonConvert.DeserializeObject<List<resItem>>(jsonString);
            if (resCollection == null)
                resCollection.Add(new resItem() { id = 10, name = "+" });
            Collection_to_list();
            CalculateSummBytes();
        }

        private void Collection_to_list()
        {
            listBox1.Items.Clear();

            if (resCollection == null) return;

            foreach (resItem item in resCollection)
            {
                string str = "id: " + item.id.ToString() + "  Имя: " + item.name + "  Тип: " + item.type;
                listBox1.Items.Add(str);
            }
            LOG("Обновить listbox");
        }

        //Выбрали строку в listbox1
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            LOG(index.ToString());

            labelIndex.Text = index.ToString();
            selectedIndex = index;

            //Заполняем TextBox
            tbID.Text = resCollection[index].id.ToString();
            tbName.Text = resCollection[index].name;

            listBox2.Items.Clear();
            if (resCollection[index].type == "BMP")
            {
                listBox2.Items.Add("Высота : " + resCollection[index].H.ToString());
                listBox2.Items.Add("Ширина : " + resCollection[index].W.ToString());
                listBox2.Items.Add("Пикселей : " + resCollection[index].H * resCollection[index].W);
                listBox2.Items.Add("32b : " + resCollection[index].H * resCollection[index].W * 4);
                listBox2.Items.Add("16b : " + resCollection[index].H * resCollection[index].W * 2);
            }
            if (resCollection[index].type == "FONT")
            {
                if (resCollection[index].img_byte_arr != null)
                {
                    listBox2.Items.Add("Размер: " + resCollection[index].img_byte_arr.Length.ToString());
                    listBox2.Items.Add("Модуль 4: " + (resCollection[index].img_byte_arr.Length % 4).ToString());
                    Font_Smooth_Load();
                }
                else
                {
                    listBox2.Items.Add("Нет данных");
                }    
            }

            //Перерисовка картинки
            if ((resCollection[index].img_byte_arr != null) && (resCollection[index].type == "BMP"))
                pBox.Image = BytesToImage(resCollection[index].img_byte_arr);
            else
            {
                Graphics g = pBox.CreateGraphics();
                g.Clear(Color.Magenta);
            }

            CalculateSummBytes();

        }

        //Удаление записи
        private void bDelete_Click(object sender, EventArgs e)
        {
            resCollection.RemoveAt(selectedIndex); //Удаляем выбранную запись
            Collection_to_list();
        }

        private void buttonSaveJson_Click(object sender, EventArgs e)
        { 
            string jsonString = JsonConvert.SerializeObject(resCollection);
            File.WriteAllText("resCollection.json", jsonString);
            LOG("Сохранить json");
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных из TextBox в структуре
            resCollection[selectedIndex].id = Convert.ToInt32(tbID.Text);
            resCollection[selectedIndex].name = tbName.Text;

            Collection_to_list();
        }

        /// <summary>
        /// Кнопка открыть картинку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenPicture_Click(object sender, EventArgs e)
        {
            //При открытии помещаем в коллекцию массив
            var ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(ofd.FileName);
                Bitmap image = new Bitmap(ofd.FileName);
                resCollection[selectedIndex].img_byte_arr = ImageToBytes(image);
                resCollection[selectedIndex].H = image.Height;
                resCollection[selectedIndex].W = image.Width;
                resCollection[selectedIndex].type = "BMP";
                image.Dispose();
            }
        }



        /// <summary>
        /// Кнопка Открыть фонт и записать в img_byte_arr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFont_Click(object sender, EventArgs e)
        {
            //При открытии помещаем в коллекцию массив
            var ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                resCollection[selectedIndex].img_byte_arr = fileBytes;
                resCollection[selectedIndex].type = "FONT";
                LOG("Количество байт: " + fileBytes.Length.ToString());
            }
            Collection_to_list();
        }

        /// <summary>
        /// Кнопка удалить глиф
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGlyphDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            GliphCollection.RemoveAt(index); //Удаляем из колекции
            gFont.gCount--;

            //Перерисовка
            dataGridView1.Rows.Clear();
            foreach (Gliph g in GliphCollection)
            {
                g.data = new byte[g.gHeight * g.gWidth];
                Array.Copy(resCollection[selectedIndex].img_byte_arr, g.gBitmap, g.data, 0, g.gHeight * g.gWidth);
                dataGridView1.Rows.Add(new object[] { g.bmp, g.gUnicode.ToString(), String.Format("0X{0:X}", g.gUnicode) });
            }

        }
        
        /// <summary>
        /// Кнопка сохранить в коллекцию <br/>
        /// Проевращаем структуры фонта в массив байтов в resCollection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveFont_Click(object sender, EventArgs e)
        {
            convertGliphToImageByteArray();
        }

        /// <summary>
        /// Кнопка удалить кучу мусора за раз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGlyphDeleteArray_Click(object sender, EventArgs e)
        {

            ushort[] massiv = {0x400,0x402, 0x403, 0x404, 0x405, 0x406, 0x407, 0x408, 0x409, 0x40A, 0x40B,
                0x40C, 0x40D, 0x40E, 0x40F, 1104, 1251};
            int end = gFont.gCount;
            for (int ii = 0; ii < end; ii++)
            {
                for (int i = 0; i < GliphCollection.Count; i++)
                {
                    if (seachUnicodeInArray(GliphCollection[i].gUnicode, massiv) == true)
                    {
                        GliphCollection.RemoveAt(i);
                        gFont.gCount--;
                        break;
                    }
                }
            }

            //Перерисовка
            dataGridView1.Rows.Clear();
            foreach (Gliph g in GliphCollection)
            {   
                dataGridView1.Rows.Add(new object[] { g.bmp, g.gUnicode.ToString(), String.Format("0X{0:X}", g.gUnicode) });
            }
        }




        //Расчет общего обьема полученного пакета
        public int CalculateSummBytes()
        {
            int sum = 4 + (resCollection.Count * 48); //Заголовок и десккрипшены

            tbAllBytes.Text = "Заголовок: " + sum.ToString() + " Данные:" + " Всего";
            return sum;

        }

      
        /// <summary>
        /// Событие> Выбрана строка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;
            int selRowNum = Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value);

            LOG("g " + index.ToString());


            pBox.Image = Font_Smooth_drawGlyph((ushort)Convert.ToInt32(selRowNum));

            listBox3.Items.Clear();
            listBox3.Items.Add("Выслота: " + GliphCollection[index].gHeight.ToString());
            listBox3.Items.Add("Ширина: " + GliphCollection[index].gWidth.ToString());
            int i = GliphCollection[index].gWidth * GliphCollection[index].gHeight;
            listBox3.Items.Add("Размер: " + i.ToString());
            listBox3.Items.Add("Код: " + String.Format("#{0:X}", GliphCollection[index].gUnicode));
        }


    }



    class resItem
    {
        public int id { get; set; }              //id ресурса
        public int start_adress { get; set; }    //Стартовый адресс
        public string name { get; set; }         //Название
        public string type { get; set; }         //тип ресурса BMP FONT 
        public int H { get; set; }               //высота
        public int W { get; set; }               //ширина
        public int bit { get; set; }             //тип ресурс
        public byte[] img_byte_arr { get; set; }
    }
}
