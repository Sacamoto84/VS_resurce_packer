
namespace resurce_packer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveJson = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenPicture = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonOpenFont = new System.Windows.Forms.Button();
            this.buttonGlyphDelete = new System.Windows.Forms.Button();
            this.buttonSaveFont = new System.Windows.Forms.Button();
            this.buttonGlyphDeleteArray = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveAllToBin = new System.Windows.Forms.Button();
            this.comboBoxBMPBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.buttonSaveAdress = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(84, 274);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(128, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Удалить Строку";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(674, 5);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(198, 22);
            this.tbID.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(674, 34);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 22);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(68, 7);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(44, 16);
            this.labelIndex.TabIndex = 9;
            this.labelIndex.Text = "label4";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(383, 410);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(147, 22);
            this.tbAdress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Адресс Начала";
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 16;
            this.log.Location = new System.Drawing.Point(12, 306);
            this.log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(365, 132);
            this.log.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Индекс";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelIndex);
            this.panel1.Location = new System.Drawing.Point(218, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 29);
            this.panel1.TabIndex = 14;
            // 
            // buttonSaveJson
            // 
            this.buttonSaveJson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveJson.BackgroundImage")));
            this.buttonSaveJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveJson.Font = new System.Drawing.Font("JetBrains Mono", 16F);
            this.buttonSaveJson.Location = new System.Drawing.Point(629, 201);
            this.buttonSaveJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveJson.Name = "buttonSaveJson";
            this.buttonSaveJson.Size = new System.Drawing.Size(243, 62);
            this.buttonSaveJson.TabIndex = 15;
            this.buttonSaveJson.Text = "JSON";
            this.buttonSaveJson.UseVisualStyleBackColor = true;
            this.buttonSaveJson.Click += new System.EventHandler(this.buttonSaveJson_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(629, 88);
            this.buttonSaveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(243, 23);
            this.buttonSaveItem.TabIndex = 16;
            this.buttonSaveItem.Text = "Сохранить строку";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Magenta;
            this.pBox.Location = new System.Drawing.Point(383, 4);
            this.pBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(240, 192);
            this.pBox.TabIndex = 17;
            this.pBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenPicture
            // 
            this.buttonOpenPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenPicture.BackgroundImage")));
            this.buttonOpenPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenPicture.Location = new System.Drawing.Point(629, 130);
            this.buttonOpenPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenPicture.Name = "buttonOpenPicture";
            this.buttonOpenPicture.Size = new System.Drawing.Size(243, 66);
            this.buttonOpenPicture.TabIndex = 18;
            this.buttonOpenPicture.Text = "Открыть картинку";
            this.buttonOpenPicture.UseVisualStyleBackColor = true;
            this.buttonOpenPicture.Click += new System.EventHandler(this.buttonOpenPicture_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("JetBrains Mono", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 26;
            this.listBox2.Location = new System.Drawing.Point(383, 201);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 108);
            this.listBox2.TabIndex = 22;
            // 
            // buttonOpenFont
            // 
            this.buttonOpenFont.Location = new System.Drawing.Point(878, 258);
            this.buttonOpenFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenFont.Name = "buttonOpenFont";
            this.buttonOpenFont.Size = new System.Drawing.Size(175, 37);
            this.buttonOpenFont.TabIndex = 23;
            this.buttonOpenFont.Text = "Открыть Фонт";
            this.buttonOpenFont.UseVisualStyleBackColor = true;
            this.buttonOpenFont.Click += new System.EventHandler(this.buttonOpenFont_Click);
            // 
            // buttonGlyphDelete
            // 
            this.buttonGlyphDelete.Location = new System.Drawing.Point(878, 192);
            this.buttonGlyphDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGlyphDelete.Name = "buttonGlyphDelete";
            this.buttonGlyphDelete.Size = new System.Drawing.Size(175, 61);
            this.buttonGlyphDelete.TabIndex = 26;
            this.buttonGlyphDelete.Text = "Удалить глиф";
            this.buttonGlyphDelete.UseVisualStyleBackColor = true;
            this.buttonGlyphDelete.Click += new System.EventHandler(this.buttonGlyphDelete_Click);
            // 
            // buttonSaveFont
            // 
            this.buttonSaveFont.Location = new System.Drawing.Point(878, 7);
            this.buttonSaveFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveFont.Name = "buttonSaveFont";
            this.buttonSaveFont.Size = new System.Drawing.Size(175, 48);
            this.buttonSaveFont.TabIndex = 27;
            this.buttonSaveFont.Text = "Сохранить в колекцию";
            this.buttonSaveFont.UseVisualStyleBackColor = true;
            this.buttonSaveFont.Click += new System.EventHandler(this.buttonSaveFont_Click);
            // 
            // buttonGlyphDeleteArray
            // 
            this.buttonGlyphDeleteArray.Location = new System.Drawing.Point(878, 164);
            this.buttonGlyphDeleteArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGlyphDeleteArray.Name = "buttonGlyphDeleteArray";
            this.buttonGlyphDeleteArray.Size = new System.Drawing.Size(175, 23);
            this.buttonGlyphDeleteArray.TabIndex = 28;
            this.buttonGlyphDeleteArray.Text = "Удалить мусор";
            this.buttonGlyphDeleteArray.UseVisualStyleBackColor = true;
            this.buttonGlyphDeleteArray.Click += new System.EventHandler(this.buttonGlyphDeleteArray_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(878, 60);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(175, 100);
            this.listBox3.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(1059, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 64;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(307, 382);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Глиф";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 47;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unicode";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HEX";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // buttonSaveAllToBin
            // 
            this.buttonSaveAllToBin.Location = new System.Drawing.Point(629, 334);
            this.buttonSaveAllToBin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveAllToBin.Name = "buttonSaveAllToBin";
            this.buttonSaveAllToBin.Size = new System.Drawing.Size(243, 55);
            this.buttonSaveAllToBin.TabIndex = 33;
            this.buttonSaveAllToBin.Text = "Сохнанит все в BIN";
            this.buttonSaveAllToBin.UseVisualStyleBackColor = true;
            this.buttonSaveAllToBin.Click += new System.EventHandler(this.buttonSaveAllToBin_Click);
            // 
            // comboBoxBMPBit
            // 
            this.comboBoxBMPBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBMPBit.FormattingEnabled = true;
            this.comboBoxBMPBit.Items.AddRange(new object[] {
            "32",
            "24",
            "16",
            "0"});
            this.comboBoxBMPBit.Location = new System.Drawing.Point(674, 61);
            this.comboBoxBMPBit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBMPBit.Name = "comboBoxBMPBit";
            this.comboBoxBMPBit.Size = new System.Drawing.Size(198, 24);
            this.comboBoxBMPBit.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bit";
            // 
            // buttonFlash
            // 
            this.buttonFlash.Location = new System.Drawing.Point(383, 334);
            this.buttonFlash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(240, 55);
            this.buttonFlash.TabIndex = 36;
            this.buttonFlash.Text = "Прошить";
            this.buttonFlash.UseVisualStyleBackColor = true;
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
            // 
            // buttonSaveAdress
            // 
            this.buttonSaveAdress.Location = new System.Drawing.Point(536, 410);
            this.buttonSaveAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveAdress.Name = "buttonSaveAdress";
            this.buttonSaveAdress.Size = new System.Drawing.Size(87, 23);
            this.buttonSaveAdress.TabIndex = 37;
            this.buttonSaveAdress.Text = "Save";
            this.buttonSaveAdress.UseVisualStyleBackColor = true;
            this.buttonSaveAdress.Click += new System.EventHandler(this.buttonSaveAdress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 444);
            this.Controls.Add(this.buttonSaveAdress);
            this.Controls.Add(this.buttonFlash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBMPBit);
            this.Controls.Add(this.buttonSaveAllToBin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.buttonGlyphDeleteArray);
            this.Controls.Add(this.buttonSaveFont);
            this.Controls.Add(this.buttonGlyphDelete);
            this.Controls.Add(this.buttonOpenFont);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonOpenPicture);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.buttonSaveJson);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveJson;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenPicture;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonOpenFont;
        private System.Windows.Forms.Button buttonGlyphDelete;
        private System.Windows.Forms.Button buttonSaveFont;
        private System.Windows.Forms.Button buttonGlyphDeleteArray;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonSaveAllToBin;
        private System.Windows.Forms.ComboBox comboBoxBMPBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.Button buttonSaveAdress;
    }
}
