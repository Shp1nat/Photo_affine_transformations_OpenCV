
namespace _3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.zagruzitImage = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.Button();
            this.menu2 = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Button();
            this.menu4 = new System.Windows.Forms.Button();
            this.menu6 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.chooseXY = new System.Windows.Forms.TextBox();
            this.koefForX = new System.Windows.Forms.TextBox();
            this.koefForY = new System.Windows.Forms.TextBox();
            this.convertFor1 = new System.Windows.Forms.Button();
            this.koefX = new System.Windows.Forms.TextBox();
            this.koefY = new System.Windows.Forms.TextBox();
            this.koefXplus = new System.Windows.Forms.Button();
            this.koefYplus = new System.Windows.Forms.Button();
            this.koefYminus = new System.Windows.Forms.Button();
            this.koefXminus = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chooseKforSharing = new System.Windows.Forms.TextBox();
            this.KforShearing = new System.Windows.Forms.TextBox();
            this.shearingKminus = new System.Windows.Forms.Button();
            this.shearingKplus = new System.Windows.Forms.Button();
            this.convertFor2 = new System.Windows.Forms.Button();
            this.chooseXYandAngle = new System.Windows.Forms.TextBox();
            this.XforTurn = new System.Windows.Forms.TextBox();
            this.YforTurn = new System.Windows.Forms.TextBox();
            this.angelForTurn = new System.Windows.Forms.TextBox();
            this.nudForXforTurn = new System.Windows.Forms.NumericUpDown();
            this.nudForYforTurn = new System.Windows.Forms.NumericUpDown();
            this.nudForAngelForTurn = new System.Windows.Forms.NumericUpDown();
            this.convertFor3 = new System.Windows.Forms.Button();
            this.chooseReflection = new System.Windows.Forms.TextBox();
            this.convertFor4gor = new System.Windows.Forms.Button();
            this.convertFor4vert = new System.Windows.Forms.Button();
            this.convertFor4gorvert = new System.Windows.Forms.Button();
            this.convertFor6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForXforTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForYforTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForAngelForTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(733, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(707, 614);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // zagruzitImage
            // 
            this.zagruzitImage.Location = new System.Drawing.Point(140, 21);
            this.zagruzitImage.Name = "zagruzitImage";
            this.zagruzitImage.Size = new System.Drawing.Size(92, 37);
            this.zagruzitImage.TabIndex = 3;
            this.zagruzitImage.Text = "Загрузить изображение";
            this.zagruzitImage.UseVisualStyleBackColor = true;
            this.zagruzitImage.Click += new System.EventHandler(this.zagruzitImage_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(140, 75);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(92, 30);
            this.menu.TabIndex = 4;
            this.menu.Text = "Меню";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(58, 111);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(258, 52);
            this.menu1.TabIndex = 5;
            this.menu1.Text = "1. Масштабирование изображения с параметрами";
            this.menu1.UseVisualStyleBackColor = true;
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menu2
            // 
            this.menu2.Location = new System.Drawing.Point(58, 169);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(258, 52);
            this.menu2.TabIndex = 6;
            this.menu2.Text = "2. Осуществить сдвиг изображения на произвольное значение";
            this.menu2.UseVisualStyleBackColor = true;
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // menu3
            // 
            this.menu3.Location = new System.Drawing.Point(58, 227);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(258, 52);
            this.menu3.TabIndex = 7;
            this.menu3.Text = "3. Поворот изображения";
            this.menu3.UseVisualStyleBackColor = true;
            this.menu3.Click += new System.EventHandler(this.menu3_Click);
            // 
            // menu4
            // 
            this.menu4.Location = new System.Drawing.Point(58, 285);
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(258, 52);
            this.menu4.TabIndex = 8;
            this.menu4.Text = "4. Отражение изображения одним из четырёх способов";
            this.menu4.UseVisualStyleBackColor = true;
            this.menu4.Click += new System.EventHandler(this.menu4_Click);
            // 
            // menu6
            // 
            this.menu6.Location = new System.Drawing.Point(58, 343);
            this.menu6.Name = "menu6";
            this.menu6.Size = new System.Drawing.Size(258, 52);
            this.menu6.TabIndex = 10;
            this.menu6.Text = "5. Осуществление проекции фрагмента изображения на произвольную плоскость";
            this.menu6.UseVisualStyleBackColor = true;
            this.menu6.Click += new System.EventHandler(this.menu6_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(140, 75);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 30);
            this.back.TabIndex = 11;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // chooseXY
            // 
            this.chooseXY.Location = new System.Drawing.Point(471, 169);
            this.chooseXY.Name = "chooseXY";
            this.chooseXY.ReadOnly = true;
            this.chooseXY.Size = new System.Drawing.Size(140, 20);
            this.chooseXY.TabIndex = 14;
            this.chooseXY.Text = "Выберите коэффициенты";
            this.chooseXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseXY.Visible = false;
            // 
            // koefForX
            // 
            this.koefForX.Location = new System.Drawing.Point(471, 211);
            this.koefForX.Name = "koefForX";
            this.koefForX.ReadOnly = true;
            this.koefForX.Size = new System.Drawing.Size(37, 20);
            this.koefForX.TabIndex = 15;
            this.koefForX.Text = "X";
            this.koefForX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.koefForX.Visible = false;
            // 
            // koefForY
            // 
            this.koefForY.Location = new System.Drawing.Point(574, 211);
            this.koefForY.Name = "koefForY";
            this.koefForY.ReadOnly = true;
            this.koefForY.Size = new System.Drawing.Size(37, 20);
            this.koefForY.TabIndex = 16;
            this.koefForY.Text = "Y";
            this.koefForY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.koefForY.Visible = false;
            // 
            // convertFor1
            // 
            this.convertFor1.Enabled = false;
            this.convertFor1.Location = new System.Drawing.Point(471, 273);
            this.convertFor1.Name = "convertFor1";
            this.convertFor1.Size = new System.Drawing.Size(140, 31);
            this.convertFor1.TabIndex = 17;
            this.convertFor1.Text = "Преобразовать";
            this.convertFor1.UseVisualStyleBackColor = true;
            this.convertFor1.Visible = false;
            this.convertFor1.Click += new System.EventHandler(this.convertFor1_Click);
            // 
            // koefX
            // 
            this.koefX.Location = new System.Drawing.Point(471, 244);
            this.koefX.Name = "koefX";
            this.koefX.ReadOnly = true;
            this.koefX.Size = new System.Drawing.Size(37, 20);
            this.koefX.TabIndex = 18;
            this.koefX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.koefX.Visible = false;
            // 
            // koefY
            // 
            this.koefY.Location = new System.Drawing.Point(574, 244);
            this.koefY.Name = "koefY";
            this.koefY.ReadOnly = true;
            this.koefY.Size = new System.Drawing.Size(37, 20);
            this.koefY.TabIndex = 19;
            this.koefY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.koefY.Visible = false;
            // 
            // koefXplus
            // 
            this.koefXplus.Enabled = false;
            this.koefXplus.Location = new System.Drawing.Point(514, 244);
            this.koefXplus.Name = "koefXplus";
            this.koefXplus.Size = new System.Drawing.Size(23, 20);
            this.koefXplus.TabIndex = 20;
            this.koefXplus.Text = "+";
            this.koefXplus.UseVisualStyleBackColor = true;
            this.koefXplus.Visible = false;
            this.koefXplus.Click += new System.EventHandler(this.koefXplus_Click);
            // 
            // koefYplus
            // 
            this.koefYplus.Enabled = false;
            this.koefYplus.Location = new System.Drawing.Point(617, 244);
            this.koefYplus.Name = "koefYplus";
            this.koefYplus.Size = new System.Drawing.Size(23, 20);
            this.koefYplus.TabIndex = 21;
            this.koefYplus.Text = "+";
            this.koefYplus.UseVisualStyleBackColor = true;
            this.koefYplus.Visible = false;
            this.koefYplus.Click += new System.EventHandler(this.koefYplus_Click);
            // 
            // koefYminus
            // 
            this.koefYminus.Enabled = false;
            this.koefYminus.Location = new System.Drawing.Point(545, 244);
            this.koefYminus.Name = "koefYminus";
            this.koefYminus.Size = new System.Drawing.Size(23, 20);
            this.koefYminus.TabIndex = 22;
            this.koefYminus.Text = "-";
            this.koefYminus.UseVisualStyleBackColor = true;
            this.koefYminus.Visible = false;
            this.koefYminus.Click += new System.EventHandler(this.koefYminus_Click);
            // 
            // koefXminus
            // 
            this.koefXminus.Enabled = false;
            this.koefXminus.Location = new System.Drawing.Point(442, 244);
            this.koefXminus.Name = "koefXminus";
            this.koefXminus.Size = new System.Drawing.Size(23, 20);
            this.koefXminus.TabIndex = 23;
            this.koefXminus.Text = "-";
            this.koefXminus.UseVisualStyleBackColor = true;
            this.koefXminus.Visible = false;
            this.koefXminus.Click += new System.EventHandler(this.koefXminus_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 638);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // chooseKforSharing
            // 
            this.chooseKforSharing.Location = new System.Drawing.Point(471, 169);
            this.chooseKforSharing.Name = "chooseKforSharing";
            this.chooseKforSharing.ReadOnly = true;
            this.chooseKforSharing.Size = new System.Drawing.Size(140, 20);
            this.chooseKforSharing.TabIndex = 25;
            this.chooseKforSharing.Text = "Выберите коэффициент";
            this.chooseKforSharing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseKforSharing.Visible = false;
            // 
            // KforShearing
            // 
            this.KforShearing.Location = new System.Drawing.Point(523, 211);
            this.KforShearing.Name = "KforShearing";
            this.KforShearing.ReadOnly = true;
            this.KforShearing.Size = new System.Drawing.Size(37, 20);
            this.KforShearing.TabIndex = 26;
            this.KforShearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KforShearing.Visible = false;
            // 
            // shearingKminus
            // 
            this.shearingKminus.Enabled = false;
            this.shearingKminus.Location = new System.Drawing.Point(494, 211);
            this.shearingKminus.Name = "shearingKminus";
            this.shearingKminus.Size = new System.Drawing.Size(23, 20);
            this.shearingKminus.TabIndex = 27;
            this.shearingKminus.Text = "-";
            this.shearingKminus.UseVisualStyleBackColor = true;
            this.shearingKminus.Visible = false;
            this.shearingKminus.Click += new System.EventHandler(this.shearingKminus_Click);
            // 
            // shearingKplus
            // 
            this.shearingKplus.Enabled = false;
            this.shearingKplus.Location = new System.Drawing.Point(566, 211);
            this.shearingKplus.Name = "shearingKplus";
            this.shearingKplus.Size = new System.Drawing.Size(23, 20);
            this.shearingKplus.TabIndex = 28;
            this.shearingKplus.Text = "+";
            this.shearingKplus.UseVisualStyleBackColor = true;
            this.shearingKplus.Visible = false;
            this.shearingKplus.Click += new System.EventHandler(this.shearingKplus_Click);
            // 
            // convertFor2
            // 
            this.convertFor2.Enabled = false;
            this.convertFor2.Location = new System.Drawing.Point(471, 273);
            this.convertFor2.Name = "convertFor2";
            this.convertFor2.Size = new System.Drawing.Size(140, 31);
            this.convertFor2.TabIndex = 29;
            this.convertFor2.Text = "Преобразовать";
            this.convertFor2.UseVisualStyleBackColor = true;
            this.convertFor2.Visible = false;
            this.convertFor2.Click += new System.EventHandler(this.convertFor2_Click);
            // 
            // chooseXYandAngle
            // 
            this.chooseXYandAngle.Location = new System.Drawing.Point(442, 169);
            this.chooseXYandAngle.Name = "chooseXYandAngle";
            this.chooseXYandAngle.ReadOnly = true;
            this.chooseXYandAngle.Size = new System.Drawing.Size(198, 20);
            this.chooseXYandAngle.TabIndex = 30;
            this.chooseXYandAngle.Text = "Выберите координаты и угол";
            this.chooseXYandAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseXYandAngle.Visible = false;
            // 
            // XforTurn
            // 
            this.XforTurn.Location = new System.Drawing.Point(442, 211);
            this.XforTurn.Name = "XforTurn";
            this.XforTurn.ReadOnly = true;
            this.XforTurn.Size = new System.Drawing.Size(66, 20);
            this.XforTurn.TabIndex = 31;
            this.XforTurn.Text = "X";
            this.XforTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XforTurn.Visible = false;
            // 
            // YforTurn
            // 
            this.YforTurn.Location = new System.Drawing.Point(508, 211);
            this.YforTurn.Name = "YforTurn";
            this.YforTurn.ReadOnly = true;
            this.YforTurn.Size = new System.Drawing.Size(66, 20);
            this.YforTurn.TabIndex = 32;
            this.YforTurn.Text = "Y";
            this.YforTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YforTurn.Visible = false;
            // 
            // angelForTurn
            // 
            this.angelForTurn.Location = new System.Drawing.Point(574, 211);
            this.angelForTurn.Name = "angelForTurn";
            this.angelForTurn.ReadOnly = true;
            this.angelForTurn.Size = new System.Drawing.Size(66, 20);
            this.angelForTurn.TabIndex = 33;
            this.angelForTurn.Text = "Angel";
            this.angelForTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angelForTurn.Visible = false;
            // 
            // nudForXforTurn
            // 
            this.nudForXforTurn.Enabled = false;
            this.nudForXforTurn.Location = new System.Drawing.Point(442, 244);
            this.nudForXforTurn.Name = "nudForXforTurn";
            this.nudForXforTurn.Size = new System.Drawing.Size(66, 20);
            this.nudForXforTurn.TabIndex = 34;
            this.nudForXforTurn.Visible = false;
            // 
            // nudForYforTurn
            // 
            this.nudForYforTurn.Enabled = false;
            this.nudForYforTurn.Location = new System.Drawing.Point(508, 244);
            this.nudForYforTurn.Name = "nudForYforTurn";
            this.nudForYforTurn.Size = new System.Drawing.Size(66, 20);
            this.nudForYforTurn.TabIndex = 35;
            this.nudForYforTurn.Visible = false;
            // 
            // nudForAngelForTurn
            // 
            this.nudForAngelForTurn.Enabled = false;
            this.nudForAngelForTurn.Location = new System.Drawing.Point(574, 244);
            this.nudForAngelForTurn.Name = "nudForAngelForTurn";
            this.nudForAngelForTurn.Size = new System.Drawing.Size(66, 20);
            this.nudForAngelForTurn.TabIndex = 36;
            this.nudForAngelForTurn.Visible = false;
            // 
            // convertFor3
            // 
            this.convertFor3.Enabled = false;
            this.convertFor3.Location = new System.Drawing.Point(471, 273);
            this.convertFor3.Name = "convertFor3";
            this.convertFor3.Size = new System.Drawing.Size(140, 31);
            this.convertFor3.TabIndex = 37;
            this.convertFor3.Text = "Преобразовать";
            this.convertFor3.UseVisualStyleBackColor = true;
            this.convertFor3.Visible = false;
            this.convertFor3.Click += new System.EventHandler(this.convertFor3_Click);
            // 
            // chooseReflection
            // 
            this.chooseReflection.Location = new System.Drawing.Point(442, 169);
            this.chooseReflection.Name = "chooseReflection";
            this.chooseReflection.ReadOnly = true;
            this.chooseReflection.Size = new System.Drawing.Size(198, 20);
            this.chooseReflection.TabIndex = 38;
            this.chooseReflection.Text = "Выберите отражение картинки";
            this.chooseReflection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseReflection.Visible = false;
            // 
            // convertFor4gor
            // 
            this.convertFor4gor.Enabled = false;
            this.convertFor4gor.Location = new System.Drawing.Point(456, 211);
            this.convertFor4gor.Name = "convertFor4gor";
            this.convertFor4gor.Size = new System.Drawing.Size(169, 41);
            this.convertFor4gor.TabIndex = 39;
            this.convertFor4gor.Text = "Отразить по горизонтали";
            this.convertFor4gor.UseVisualStyleBackColor = true;
            this.convertFor4gor.Visible = false;
            this.convertFor4gor.Click += new System.EventHandler(this.convertFor4gor_Click);
            // 
            // convertFor4vert
            // 
            this.convertFor4vert.Enabled = false;
            this.convertFor4vert.Location = new System.Drawing.Point(456, 258);
            this.convertFor4vert.Name = "convertFor4vert";
            this.convertFor4vert.Size = new System.Drawing.Size(169, 41);
            this.convertFor4vert.TabIndex = 40;
            this.convertFor4vert.Text = "Отразить по вертикали";
            this.convertFor4vert.UseVisualStyleBackColor = true;
            this.convertFor4vert.Visible = false;
            this.convertFor4vert.Click += new System.EventHandler(this.convertFor4vert_Click);
            // 
            // convertFor4gorvert
            // 
            this.convertFor4gorvert.Enabled = false;
            this.convertFor4gorvert.Location = new System.Drawing.Point(456, 305);
            this.convertFor4gorvert.Name = "convertFor4gorvert";
            this.convertFor4gorvert.Size = new System.Drawing.Size(169, 41);
            this.convertFor4gorvert.TabIndex = 41;
            this.convertFor4gorvert.Text = "Отразить по горизонтали и вертикали";
            this.convertFor4gorvert.UseVisualStyleBackColor = true;
            this.convertFor4gorvert.Visible = false;
            this.convertFor4gorvert.Click += new System.EventHandler(this.convertFor4gorvert_Click);
            // 
            // convertFor6
            // 
            this.convertFor6.Enabled = false;
            this.convertFor6.Location = new System.Drawing.Point(471, 263);
            this.convertFor6.Name = "convertFor6";
            this.convertFor6.Size = new System.Drawing.Size(140, 31);
            this.convertFor6.TabIndex = 42;
            this.convertFor6.Text = "Преобразовать";
            this.convertFor6.UseVisualStyleBackColor = true;
            this.convertFor6.Visible = false;
            this.convertFor6.Click += new System.EventHandler(this.convertFor6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 638);
            this.Controls.Add(this.convertFor6);
            this.Controls.Add(this.convertFor4gorvert);
            this.Controls.Add(this.convertFor4vert);
            this.Controls.Add(this.convertFor4gor);
            this.Controls.Add(this.chooseReflection);
            this.Controls.Add(this.convertFor3);
            this.Controls.Add(this.nudForAngelForTurn);
            this.Controls.Add(this.nudForYforTurn);
            this.Controls.Add(this.nudForXforTurn);
            this.Controls.Add(this.angelForTurn);
            this.Controls.Add(this.YforTurn);
            this.Controls.Add(this.XforTurn);
            this.Controls.Add(this.chooseXYandAngle);
            this.Controls.Add(this.convertFor2);
            this.Controls.Add(this.shearingKplus);
            this.Controls.Add(this.shearingKminus);
            this.Controls.Add(this.KforShearing);
            this.Controls.Add(this.chooseKforSharing);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.koefXminus);
            this.Controls.Add(this.koefYminus);
            this.Controls.Add(this.koefYplus);
            this.Controls.Add(this.koefXplus);
            this.Controls.Add(this.koefY);
            this.Controls.Add(this.koefX);
            this.Controls.Add(this.convertFor1);
            this.Controls.Add(this.koefForY);
            this.Controls.Add(this.koefForX);
            this.Controls.Add(this.chooseXY);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menu6);
            this.Controls.Add(this.menu4);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.zagruzitImage);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForXforTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForYforTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudForAngelForTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button zagruzitImage;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button menu1;
        private System.Windows.Forms.Button menu2;
        private System.Windows.Forms.Button menu3;
        private System.Windows.Forms.Button menu4;
        private System.Windows.Forms.Button menu6;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox chooseXY;
        private System.Windows.Forms.TextBox koefForX;
        private System.Windows.Forms.TextBox koefForY;
        private System.Windows.Forms.Button convertFor1;
        private System.Windows.Forms.TextBox koefX;
        private System.Windows.Forms.TextBox koefY;
        private System.Windows.Forms.Button koefXplus;
        private System.Windows.Forms.Button koefYplus;
        private System.Windows.Forms.Button koefYminus;
        private System.Windows.Forms.Button koefXminus;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox chooseKforSharing;
        private System.Windows.Forms.TextBox KforShearing;
        private System.Windows.Forms.Button shearingKminus;
        private System.Windows.Forms.Button shearingKplus;
        private System.Windows.Forms.Button convertFor2;
        private System.Windows.Forms.TextBox chooseXYandAngle;
        private System.Windows.Forms.TextBox XforTurn;
        private System.Windows.Forms.TextBox YforTurn;
        private System.Windows.Forms.TextBox angelForTurn;
        private System.Windows.Forms.NumericUpDown nudForXforTurn;
        private System.Windows.Forms.NumericUpDown nudForYforTurn;
        private System.Windows.Forms.NumericUpDown nudForAngelForTurn;
        private System.Windows.Forms.Button convertFor3;
        private System.Windows.Forms.TextBox chooseReflection;
        private System.Windows.Forms.Button convertFor4gor;
        private System.Windows.Forms.Button convertFor4vert;
        private System.Windows.Forms.Button convertFor4gorvert;
        private System.Windows.Forms.Button convertFor6;
    }
}

