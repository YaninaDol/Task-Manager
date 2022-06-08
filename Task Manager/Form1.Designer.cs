
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace Task_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Процессы = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.CPULB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProcCpuLB = new System.Windows.Forms.Label();
            this.ProcRamLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьНовуюЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поверхОстальныхОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сворачиватьПослеОбращенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрыватьСвернутоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСейчасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьОбновленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.группироватьПоТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.развернутьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Процессы
            // 
            this.Процессы.BackColor = System.Drawing.SystemColors.Window;
            this.Процессы.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Процессы.Location = new System.Drawing.Point(-4, 31);
            this.Процессы.Name = "Процессы";
            this.Процессы.Size = new System.Drawing.Size(90, 31);
            this.Процессы.TabIndex = 0;
            this.Процессы.Text = "Процессы";
            this.Процессы.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(-4, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 408);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(81, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Производительность";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(232, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Журнал приложений";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(390, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Автозагрузка";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(501, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Пользователи";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(720, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Службы";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(606, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Подробности";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // CPULB
            // 
            this.CPULB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPULB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPULB.Location = new System.Drawing.Point(12, 65);
            this.CPULB.Name = "CPULB";
            this.CPULB.Size = new System.Drawing.Size(70, 30);
            this.CPULB.TabIndex = 7;
            this.CPULB.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(228, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Состояние";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(364, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "ЦП";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(471, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Память";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(602, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Диск";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(682, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сеть";
            // 
            // ProcCpuLB
            // 
            this.ProcCpuLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcCpuLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProcCpuLB.Location = new System.Drawing.Point(364, 95);
            this.ProcCpuLB.Name = "ProcCpuLB";
            this.ProcCpuLB.Size = new System.Drawing.Size(79, 30);
            this.ProcCpuLB.TabIndex = 13;
            this.ProcCpuLB.Text = "%";
            // 
            // ProcRamLB
            // 
            this.ProcRamLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcRamLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProcRamLB.Location = new System.Drawing.Point(480, 95);
            this.ProcRamLB.Name = "ProcRamLB";
            this.ProcRamLB.Size = new System.Drawing.Size(87, 30);
            this.ProcRamLB.TabIndex = 14;
            this.ProcRamLB.Text = "%";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(611, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "0%";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(692, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "0%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьНовуюЗадачуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // запуститьНовуюЗадачуToolStripMenuItem
            // 
            this.запуститьНовуюЗадачуToolStripMenuItem.Name = "запуститьНовуюЗадачуToolStripMenuItem";
            this.запуститьНовуюЗадачуToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.запуститьНовуюЗадачуToolStripMenuItem.Text = "Запустить новую задачу";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхОстальныхОконToolStripMenuItem,
            this.сворачиватьПослеОбращенияToolStripMenuItem,
            this.скрыватьСвернутоеToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // поверхОстальныхОконToolStripMenuItem
            // 
            this.поверхОстальныхОконToolStripMenuItem.Name = "поверхОстальныхОконToolStripMenuItem";
            this.поверхОстальныхОконToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.поверхОстальныхОконToolStripMenuItem.Text = "Поверх остальных окон";
            // 
            // сворачиватьПослеОбращенияToolStripMenuItem
            // 
            this.сворачиватьПослеОбращенияToolStripMenuItem.Name = "сворачиватьПослеОбращенияToolStripMenuItem";
            this.сворачиватьПослеОбращенияToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.сворачиватьПослеОбращенияToolStripMenuItem.Text = "Сворачивать после обращения";
            // 
            // скрыватьСвернутоеToolStripMenuItem
            // 
            this.скрыватьСвернутоеToolStripMenuItem.Name = "скрыватьСвернутоеToolStripMenuItem";
            this.скрыватьСвернутоеToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.скрыватьСвернутоеToolStripMenuItem.Text = "Скрывать свернутое";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьСейчасToolStripMenuItem,
            this.скоростьОбновленияToolStripMenuItem,
            this.toolStripSeparator1,
            this.группироватьПоТипуToolStripMenuItem,
            this.свернутьВсеToolStripMenuItem,
            this.развернутьВсеToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // обновитьСейчасToolStripMenuItem
            // 
            this.обновитьСейчасToolStripMenuItem.Name = "обновитьСейчасToolStripMenuItem";
            this.обновитьСейчасToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.обновитьСейчасToolStripMenuItem.Text = "Обновить сейчас";
            this.обновитьСейчасToolStripMenuItem.Click += new System.EventHandler(this.обновитьСейчасToolStripMenuItem_Click);
            // 
            // скоростьОбновленияToolStripMenuItem
            // 
            this.скоростьОбновленияToolStripMenuItem.Name = "скоростьОбновленияToolStripMenuItem";
            this.скоростьОбновленияToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.скоростьОбновленияToolStripMenuItem.Text = "Скорость обновления";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // группироватьПоТипуToolStripMenuItem
            // 
            this.группироватьПоТипуToolStripMenuItem.Name = "группироватьПоТипуToolStripMenuItem";
            this.группироватьПоТипуToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.группироватьПоТипуToolStripMenuItem.Text = "Группировать по типу";
            // 
            // свернутьВсеToolStripMenuItem
            // 
            this.свернутьВсеToolStripMenuItem.Name = "свернутьВсеToolStripMenuItem";
            this.свернутьВсеToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.свернутьВсеToolStripMenuItem.Text = "Свернуть все";
            // 
            // развернутьВсеToolStripMenuItem
            // 
            this.развернутьВсеToolStripMenuItem.Name = "развернутьВсеToolStripMenuItem";
            this.развернутьВсеToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.развернутьВсеToolStripMenuItem.Text = "Развернуть все";
            // 
            // timer
            // 
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000;

            timer.Tick += this.обновитьСейчасToolStripMenuItem_Click;

            timer.Start();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProcRamLB);
            this.Controls.Add(this.ProcCpuLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPULB);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Процессы);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диспетчер задач";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Процессы;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label CPULB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProcCpuLB;
        private System.Windows.Forms.Label ProcRamLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьНовуюЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поверхОстальныхОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сворачиватьПослеОбращенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрыватьСвернутоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСейчасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьОбновленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem группироватьПоТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свернутьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem развернутьВсеToolStripMenuItem;
   
    }
}

