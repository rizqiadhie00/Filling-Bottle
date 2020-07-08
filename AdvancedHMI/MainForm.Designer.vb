<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.RUN_2 = New System.Windows.Forms.Timer(Me.components)
        Me.Bottle_In = New AdvancedHMIControls.AnalogValueDisplay()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.EthernetIPforCLXCom1
        Me.DigitalPanelMeter1.DecimalPosition = 0
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(15, 9)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40101"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(223, 97)
        Me.DigitalPanelMeter1.TabIndex = 4
        Me.DigitalPanelMeter1.Text = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "127.0.0.1"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 500
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'RUN_2
        '
        Me.RUN_2.Enabled = True
        Me.RUN_2.Interval = 1000
        '
        'Bottle_In
        '
        Me.Bottle_In.AutoSize = True
        Me.Bottle_In.ComComponent = Me.ModbusTCPCom1
        Me.Bottle_In.ForeColor = System.Drawing.Color.White
        Me.Bottle_In.ForeColorInLimits = System.Drawing.Color.White
        Me.Bottle_In.ForeColorOverLimit = System.Drawing.Color.Red
        Me.Bottle_In.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.Bottle_In.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Bottle_In.KeypadMaxValue = 0R
        Me.Bottle_In.KeypadMinValue = 0R
        Me.Bottle_In.KeypadPasscode = Nothing
        Me.Bottle_In.KeypadScaleFactor = 1.0R
        Me.Bottle_In.KeypadText = Nothing
        Me.Bottle_In.KeypadWidth = 300
        Me.Bottle_In.Location = New System.Drawing.Point(12, 9)
        Me.Bottle_In.Name = "Bottle_In"
        Me.Bottle_In.NumericFormat = Nothing
        Me.Bottle_In.PLCAddressKeypad = ""
        Me.Bottle_In.PLCAddressValue = CType(resources.GetObject("Bottle_In.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Bottle_In.PLCAddressValueLimitLower = Nothing
        Me.Bottle_In.PLCAddressValueLimitUpper = Nothing
        Me.Bottle_In.PLCAddressVisible = Nothing
        Me.Bottle_In.ShowValue = True
        Me.Bottle_In.Size = New System.Drawing.Size(44, 18)
        Me.Bottle_In.TabIndex = 6
        Me.Bottle_In.Text = "0000"
        Me.Bottle_In.Value = "0000"
        Me.Bottle_In.ValueLimitLower = -999999.0R
        Me.Bottle_In.ValueLimitUpper = 999999.0R
        Me.Bottle_In.ValuePrefix = Nothing
        Me.Bottle_In.ValueSuffix = Nothing
        Me.Bottle_In.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bottle_In)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents RUN_2 As Timer
    Friend WithEvents Bottle_In As AdvancedHMIControls.AnalogValueDisplay
End Class
