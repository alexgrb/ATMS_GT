namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCardID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUsrByCard = new System.Windows.Forms.Button();
            this.textBoxUsrname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Location = new System.Drawing.Point(98, 462);
            this.buttonListUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(126, 38);
            this.buttonListUsers.TabIndex = 0;
            this.buttonListUsers.Text = "List Of Users";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Available Amount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(110, 285);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(114, 36);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.Text = "Reload Account";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(110, 79);
            this.textBoxUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(173, 26);
            this.textBoxUID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert your UID";
            // 
            // textBoxAvAmount
            // 
            this.textBoxAvAmount.Location = new System.Drawing.Point(315, 78);
            this.textBoxAvAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAvAmount.Name = "textBoxAvAmount";
            this.textBoxAvAmount.Size = new System.Drawing.Size(137, 26);
            this.textBoxAvAmount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(110, 241);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(173, 26);
            this.textBoxAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Insert Amount";
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataSource = typeof(WindowsForms.ServiceReferencePrinter.UserAccount);
            // 
            // textBoxCardID
            // 
            this.textBoxCardID.Location = new System.Drawing.Point(498, 79);
            this.textBoxCardID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCardID.Name = "textBoxCardID";
            this.textBoxCardID.Size = new System.Drawing.Size(112, 26);
            this.textBoxCardID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Insert CardID";
            // 
            // buttonUsrByCard
            // 
            this.buttonUsrByCard.Location = new System.Drawing.Point(498, 138);
            this.buttonUsrByCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUsrByCard.Name = "buttonUsrByCard";
            this.buttonUsrByCard.Size = new System.Drawing.Size(198, 32);
            this.buttonUsrByCard.TabIndex = 12;
            this.buttonUsrByCard.Text = "Get UsernameByCardID";
            this.buttonUsrByCard.UseVisualStyleBackColor = true;
            this.buttonUsrByCard.Click += new System.EventHandler(this.buttonUsrByCard_Click);
            // 
            // textBoxUsrname
            // 
            this.textBoxUsrname.Location = new System.Drawing.Point(651, 78);
            this.textBoxUsrname.Name = "textBoxUsrname";
            this.textBoxUsrname.Size = new System.Drawing.Size(100, 26);
            this.textBoxUsrname.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsrname);
            this.Controls.Add(this.buttonUsrByCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAvAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonListUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAvAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private System.Windows.Forms.TextBox textBoxCardID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUsrByCard;
        private System.Windows.Forms.TextBox textBoxUsrname;
        private System.Windows.Forms.Label label5;
    }
}

