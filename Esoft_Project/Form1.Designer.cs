﻿namespace Esoft_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.White;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.Location = new System.Drawing.Point(2, 186);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.Color.White;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAgents.Location = new System.Drawing.Point(2, 236);
            this.buttonOpenAgents.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 2;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.Color.White;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(2, 288);
            this.buttonOpenRealEstates.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenRealEstates.TabIndex = 3;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.BackColor = System.Drawing.Color.White;
            this.buttonOpenDemands.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDemands.Location = new System.Drawing.Point(2, 343);
            this.buttonOpenDemands.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenDemands.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemands.TabIndex = 4;
            this.buttonOpenDemands.Text = "Предложения";
            this.buttonOpenDemands.UseVisualStyleBackColor = false;
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.Color.White;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSupplies.Location = new System.Drawing.Point(2, 395);
            this.buttonOpenSupplies.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 5;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.Color.White;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeals.Location = new System.Drawing.Point(2, 451);
            this.buttonOpenDeals.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDeals;
    }
}
