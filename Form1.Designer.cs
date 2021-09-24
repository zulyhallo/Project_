
namespace Project_
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
            //this.Delete = new System.Windows.Forms.Button();
            this.Put = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            //this.Delete.Location = new System.Drawing.Point(680, 66);
            //this.Delete.Name = "Delete";
            //this.Delete.Size = new System.Drawing.Size(96, 71);
            //this.Delete.TabIndex = 13;
            //this.Delete.Text = "Delete";
            //this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Put
            // 
            this.Put.Location = new System.Drawing.Point(580, 64);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(94, 73);
            this.Put.TabIndex = 4;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(475, 64);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(94, 73);
            this.Post.TabIndex = 5;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(32, 64);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(94, 73);
            this.GetAll.TabIndex = 6;
            this.GetAll.Text = "GetAll";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(141, 107);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(125, 30);
            this.Get.TabIndex = 7;
            this.Get.Text = "Get ";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(329, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(327, 110);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(125, 27);
            this.txtjob.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 11;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 179);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(776, 259);
            this.txtResponse.TabIndex = 12;
            this.txtResponse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Job:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.Put);
           // this.Controls.Add(this.Delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

