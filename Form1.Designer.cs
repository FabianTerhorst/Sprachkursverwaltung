namespace Sprachkursverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.members = new System.Windows.Forms.ListView();
            this.courseAdd = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.TextBox();
            this.languages = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberAdd = new System.Windows.Forms.Button();
            this.memberName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.K = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.ListView();
            this.editBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // members
            // 
            this.members.Location = new System.Drawing.Point(13, 13);
            this.members.MultiSelect = false;
            this.members.Name = "members";
            this.members.Size = new System.Drawing.Size(294, 336);
            this.members.TabIndex = 0;
            this.members.UseCompatibleStateImageBehavior = false;
            this.members.SelectedIndexChanged += new System.EventHandler(this.members_SelectedIndexChanged);
            // 
            // courseAdd
            // 
            this.courseAdd.Location = new System.Drawing.Point(342, 307);
            this.courseAdd.Name = "courseAdd";
            this.courseAdd.Size = new System.Drawing.Size(134, 23);
            this.courseAdd.TabIndex = 1;
            this.courseAdd.Text = "Hinzufügen";
            this.courseAdd.UseVisualStyleBackColor = true;
            this.courseAdd.Click += new System.EventHandler(this.courseAdd_Click);
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(342, 281);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(134, 20);
            this.courseName.TabIndex = 2;
            // 
            // languages
            // 
            this.languages.FormattingEnabled = true;
            this.languages.Location = new System.Drawing.Point(342, 254);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(134, 21);
            this.languages.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(313, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 141);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kurs hinzufügen";
            // 
            // memberAdd
            // 
            this.memberAdd.Location = new System.Drawing.Point(342, 89);
            this.memberAdd.Name = "memberAdd";
            this.memberAdd.Size = new System.Drawing.Size(134, 23);
            this.memberAdd.TabIndex = 6;
            this.memberAdd.Text = "Hinzufügen";
            this.memberAdd.UseVisualStyleBackColor = true;
            this.memberAdd.Click += new System.EventHandler(this.memberAdd_Click);
            // 
            // memberName
            // 
            this.memberName.Location = new System.Drawing.Point(342, 63);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(134, 20);
            this.memberName.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(313, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 118);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(351, 28);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(98, 13);
            this.K.TabIndex = 10;
            this.K.Text = "Mitglied hinzufügen";
            // 
            // courses
            // 
            this.courses.Location = new System.Drawing.Point(497, 12);
            this.courses.MultiSelect = false;
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(298, 337);
            this.courses.TabIndex = 11;
            this.courses.UseCompatibleStateImageBehavior = false;
            this.courses.SelectedIndexChanged += new System.EventHandler(this.courses_SelectedIndexChanged);
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(354, 161);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(100, 20);
            this.editBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 361);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.K);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.memberAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.members);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView members;
        private System.Windows.Forms.Button courseAdd;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.ComboBox languages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button memberAdd;
        private System.Windows.Forms.TextBox memberName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.ListView courses;
        private System.Windows.Forms.TextBox editBox;
    }
}

