namespace EnergyMag
{
    partial class EnergyMeter3
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.meterPressure = new AppSvrHMI.L3Meter();
            this.meterFlow = new AppSvrHMI.L3Meter();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.gbxName.SuspendLayout();
            this.SuspendLayout();
            // 
            // meterPressure
            // 
            this.meterPressure.AngleRange = 180F;
            this.meterPressure.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.meterPressure.BorderColor = System.Drawing.Color.SteelBlue;
            this.meterPressure.BorderWidth = 0.1F;
            this.meterPressure.CoverColor = System.Drawing.Color.Silver;
            this.meterPressure.CoverSize = 0.02F;
            this.meterPressure.DigitGap = 0.5F;
            this.meterPressure.DigitPosition = 110F;
            this.meterPressure.DigitSize = new System.Drawing.SizeF(30F, 14F);
            this.meterPressure.Dock = System.Windows.Forms.DockStyle.Left;
            this.meterPressure.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meterPressure.ForeColor = System.Drawing.Color.DarkMagenta;
            this.meterPressure.HighProperty = null;
            this.meterPressure.HighValve = 80F;
            this.meterPressure.HighValveColor = System.Drawing.Color.Red;
            this.meterPressure.L3DataAdapter = null;
            this.meterPressure.Location = new System.Drawing.Point(0, 14);
            this.meterPressure.LowProperty = null;
            this.meterPressure.LowValve = 10F;
            this.meterPressure.LowValveColor = System.Drawing.Color.LawnGreen;
            this.meterPressure.MaxProperty = null;
            this.meterPressure.MaxValue = 100F;
            this.meterPressure.MeterObject = null;
            this.meterPressure.MinProperty = null;
            this.meterPressure.MinValue = 0F;
            this.meterPressure.Name = "meterPressure";
            this.meterPressure.PointerColor = System.Drawing.Color.BurlyWood;
            this.meterPressure.PointerLength = 0.9F;
            this.meterPressure.PointerWidth = 3F;
            this.meterPressure.Precision = 0;
            this.meterPressure.ScaleColor = System.Drawing.Color.Black;
            this.meterPressure.ScaleCount = 5;
            this.meterPressure.ScaleFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.meterPressure.ScaleGap = 0.01F;
            this.meterPressure.ScaleWidth = 5F;
            this.meterPressure.Size = new System.Drawing.Size(86, 85);
            this.meterPressure.SmoothSpeed = 0.2F;
            this.meterPressure.Smoothy = true;
            this.meterPressure.SoundAlarm = true;
            this.meterPressure.StartAngle = 180F;
            this.meterPressure.SubScaleCount = 5;
            this.meterPressure.TabIndex = 0;
            this.meterPressure.TargetValue = 40F;
            this.meterPressure.UnitText = "KPa";
            this.meterPressure.Value = 40F;
            this.meterPressure.ValueProperty = null;
            this.meterPressure.Warning = false;
            this.meterPressure.DoubleClick += new System.EventHandler(this.meterPressure_DoubleClick);
            // 
            // meterFlow
            // 
            this.meterFlow.AngleRange = 145F;
            this.meterFlow.BackColor = System.Drawing.Color.Goldenrod;
            this.meterFlow.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.meterFlow.BorderWidth = 0.1F;
            this.meterFlow.CoverColor = System.Drawing.Color.Silver;
            this.meterFlow.CoverSize = 0.02F;
            this.meterFlow.DigitGap = 0.5F;
            this.meterFlow.DigitPosition = 105F;
            this.meterFlow.DigitSize = new System.Drawing.SizeF(30F, 14F);
            this.meterFlow.Dock = System.Windows.Forms.DockStyle.Right;
            this.meterFlow.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meterFlow.ForeColor = System.Drawing.Color.Purple;
            this.meterFlow.HighProperty = null;
            this.meterFlow.HighValve = 80F;
            this.meterFlow.HighValveColor = System.Drawing.Color.Red;
            this.meterFlow.L3DataAdapter = null;
            this.meterFlow.Location = new System.Drawing.Point(59, 14);
            this.meterFlow.LowProperty = null;
            this.meterFlow.LowValve = 10F;
            this.meterFlow.LowValveColor = System.Drawing.Color.LawnGreen;
            this.meterFlow.Margin = new System.Windows.Forms.Padding(0);
            this.meterFlow.MaxProperty = null;
            this.meterFlow.MaxValue = 100F;
            this.meterFlow.MeterObject = null;
            this.meterFlow.MinProperty = null;
            this.meterFlow.MinValue = 0F;
            this.meterFlow.Name = "meterFlow";
            this.meterFlow.PointerColor = System.Drawing.Color.Gray;
            this.meterFlow.PointerLength = 0.9F;
            this.meterFlow.PointerWidth = 3F;
            this.meterFlow.Precision = 0;
            this.meterFlow.ScaleColor = System.Drawing.Color.Black;
            this.meterFlow.ScaleCount = 4;
            this.meterFlow.ScaleFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.meterFlow.ScaleGap = 0.01F;
            this.meterFlow.ScaleWidth = 5F;
            this.meterFlow.Size = new System.Drawing.Size(89, 85);
            this.meterFlow.SmoothSpeed = 0.2F;
            this.meterFlow.Smoothy = true;
            this.meterFlow.SoundAlarm = true;
            this.meterFlow.StartAngle = 235F;
            this.meterFlow.SubScaleCount = 5;
            this.meterFlow.TabIndex = 0;
            this.meterFlow.TargetValue = 40F;
            this.meterFlow.UnitText = "m³/h";
            this.meterFlow.Value = 40F;
            this.meterFlow.ValueProperty = null;
            this.meterFlow.Warning = false;
            this.meterFlow.DoubleClick += new System.EventHandler(this.meterFlow_DoubleClick);
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.meterPressure);
            this.gbxName.Controls.Add(this.meterFlow);
            this.gbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxName.Location = new System.Drawing.Point(0, 0);
            this.gbxName.Margin = new System.Windows.Forms.Padding(0);
            this.gbxName.Name = "gbxName";
            this.gbxName.Padding = new System.Windows.Forms.Padding(0);
            this.gbxName.Size = new System.Drawing.Size(148, 99);
            this.gbxName.TabIndex = 1;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "名称";
            // 
            // EnergyMeter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.gbxName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EnergyMeter3";
            this.Size = new System.Drawing.Size(148, 99);
            this.DoubleClick += new System.EventHandler(this.EnergyMeter3_DoubleClick);
            this.gbxName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Meter meterPressure;
        private AppSvrHMI.L3Meter meterFlow;
        private System.Windows.Forms.GroupBox gbxName;
    }
}
