namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonMultiple = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonAllClear = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(367, 73);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonSubtract, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.ButtonPoint, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.ButtonZero, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ButtonAllClear, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ButtonAdd, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonThree, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonTwo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonOne, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonMultiple, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonSix, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonFive, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonFour, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonDivide, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonNine, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonEight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 432);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(86, 102);
            this.ButtonSeven.TabIndex = 2;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonEight.Location = new System.Drawing.Point(95, 3);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(86, 102);
            this.ButtonEight.TabIndex = 3;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonNine.Location = new System.Drawing.Point(187, 3);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(86, 102);
            this.ButtonNine.TabIndex = 4;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDivide.Location = new System.Drawing.Point(281, 3);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(86, 102);
            this.ButtonDivide.TabIndex = 5;
            this.ButtonDivide.Text = "%";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 111);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(86, 102);
            this.ButtonFour.TabIndex = 6;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFive.Location = new System.Drawing.Point(95, 111);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(86, 102);
            this.ButtonFive.TabIndex = 7;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSix.Location = new System.Drawing.Point(187, 111);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(86, 102);
            this.ButtonSix.TabIndex = 8;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonMultiple
            // 
            this.ButtonMultiple.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMultiple.Location = new System.Drawing.Point(281, 111);
            this.ButtonMultiple.Name = "ButtonMultiple";
            this.ButtonMultiple.Size = new System.Drawing.Size(86, 102);
            this.ButtonMultiple.TabIndex = 9;
            this.ButtonMultiple.Text = "*";
            this.ButtonMultiple.UseVisualStyleBackColor = true;
            this.ButtonMultiple.Click += new System.EventHandler(this.ButtonMultiple_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 219);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(86, 102);
            this.ButtonOne.TabIndex = 10;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTwo.Location = new System.Drawing.Point(95, 219);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(86, 102);
            this.ButtonTwo.TabIndex = 11;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonThree.Location = new System.Drawing.Point(187, 219);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(86, 102);
            this.ButtonThree.TabIndex = 12;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAdd.Location = new System.Drawing.Point(281, 219);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(86, 102);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonAllClear
            // 
            this.ButtonAllClear.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAllClear.Location = new System.Drawing.Point(3, 327);
            this.ButtonAllClear.Name = "ButtonAllClear";
            this.ButtonAllClear.Size = new System.Drawing.Size(86, 102);
            this.ButtonAllClear.TabIndex = 14;
            this.ButtonAllClear.Text = "AC";
            this.ButtonAllClear.UseVisualStyleBackColor = true;
            this.ButtonAllClear.Click += new System.EventHandler(this.ButtonAllClear_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonZero.Location = new System.Drawing.Point(95, 327);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(86, 102);
            this.ButtonZero.TabIndex = 15;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonPoint.Location = new System.Drawing.Point(187, 327);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(86, 102);
            this.ButtonPoint.TabIndex = 16;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSubtract.Location = new System.Drawing.Point(281, 327);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(86, 102);
            this.ButtonSubtract.TabIndex = 17;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonResult.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonResult.Location = new System.Drawing.Point(0, 514);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(367, 73);
            this.ButtonResult.TabIndex = 15;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(367, 587);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonAllClear;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMultiple;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonResult;
    }
}

