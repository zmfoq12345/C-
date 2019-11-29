namespace WinForm_DB04_SELECT_INSERT_UPDATE_DELETE_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SELECT = new System.Windows.Forms.Button();
            this.btn_INSERT = new System.Windows.Forms.Button();
            this.btn_UPDATE = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.TextboxClear = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 167);
            this.panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 136);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 21);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Population";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 112);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 21);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "CountryCode";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 87);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "District";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btn_SELECT
            // 
            this.btn_SELECT.Location = new System.Drawing.Point(424, 39);
            this.btn_SELECT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SELECT.Name = "btn_SELECT";
            this.btn_SELECT.Size = new System.Drawing.Size(231, 26);
            this.btn_SELECT.TabIndex = 1;
            this.btn_SELECT.Text = "SELECT";
            this.btn_SELECT.UseVisualStyleBackColor = true;
            this.btn_SELECT.Click += new System.EventHandler(this.btn_SELECT_Click);
            // 
            // btn_INSERT
            // 
            this.btn_INSERT.Location = new System.Drawing.Point(424, 71);
            this.btn_INSERT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_INSERT.Name = "btn_INSERT";
            this.btn_INSERT.Size = new System.Drawing.Size(231, 26);
            this.btn_INSERT.TabIndex = 2;
            this.btn_INSERT.Text = "INSERT";
            this.btn_INSERT.UseVisualStyleBackColor = true;
            this.btn_INSERT.Click += new System.EventHandler(this.btn_INSERT_Click);
            // 
            // btn_UPDATE
            // 
            this.btn_UPDATE.Location = new System.Drawing.Point(424, 102);
            this.btn_UPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UPDATE.Name = "btn_UPDATE";
            this.btn_UPDATE.Size = new System.Drawing.Size(231, 26);
            this.btn_UPDATE.TabIndex = 3;
            this.btn_UPDATE.Text = "UPDATE";
            this.btn_UPDATE.UseVisualStyleBackColor = true;
            this.btn_UPDATE.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.Location = new System.Drawing.Point(424, 134);
            this.btn_DELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(231, 26);
            this.btn_DELETE.TabIndex = 4;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = true;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // TextboxClear
            // 
            this.TextboxClear.Location = new System.Drawing.Point(424, 165);
            this.TextboxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxClear.Name = "TextboxClear";
            this.TextboxClear.Size = new System.Drawing.Size(231, 26);
            this.TextboxClear.TabIndex = 5;
            this.TextboxClear.Text = "텍스트박스 지우기";
            this.TextboxClear.UseVisualStyleBackColor = true;
            this.TextboxClear.Click += new System.EventHandler(this.TextboxClear_Click);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.Location = new System.Drawing.Point(424, 14);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(231, 23);
            this.labelConnectionState.TabIndex = 6;
            this.labelConnectionState.Text = "DB 연결 상태";
            this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(134, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "WORLD.CITY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 202);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.TextboxClear);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_UPDATE);
            this.Controls.Add(this.btn_INSERT);
            this.Controls.Add(this.btn_SELECT);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SELECT;
        private System.Windows.Forms.Button btn_INSERT;
        private System.Windows.Forms.Button btn_UPDATE;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button TextboxClear;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.Label label7;
    }
}
