<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.carRentalImage = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblNumberOfMiles = New System.Windows.Forms.Label()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalCostOfRental = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.displayFare = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.carRentalImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carRentalImage
        '
        Me.carRentalImage.Image = Global.Smart_Car_Rental.My.Resources.Resources.Car_Rental
        Me.carRentalImage.Location = New System.Drawing.Point(1, 1)
        Me.carRentalImage.Name = "carRentalImage"
        Me.carRentalImage.Size = New System.Drawing.Size(446, 160)
        Me.carRentalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carRentalImage.TabIndex = 0
        Me.carRentalImage.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(122, 164)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(204, 26)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Car Rentals"
        '
        'lblSubHeading
        '
        Me.lblSubHeading.AutoSize = True
        Me.lblSubHeading.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(107, 201)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(235, 15)
        Me.lblSubHeading.TabIndex = 2
        Me.lblSubHeading.Text = "Only $29.99 Per Day Plus $0.39 Per Mile"
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(116, 231)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(136, 20)
        Me.lblNumberOfDays.TabIndex = 3
        Me.lblNumberOfDays.Text = "Number Of Days :"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(275, 228)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(77, 26)
        Me.txtNumberOfDays.TabIndex = 4
        Me.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfMiles
        '
        Me.lblNumberOfMiles.AutoSize = True
        Me.lblNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfMiles.Location = New System.Drawing.Point(116, 260)
        Me.lblNumberOfMiles.Name = "lblNumberOfMiles"
        Me.lblNumberOfMiles.Size = New System.Drawing.Size(138, 20)
        Me.lblNumberOfMiles.TabIndex = 5
        Me.lblNumberOfMiles.Text = "Number Of Miles :"
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(275, 260)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(77, 26)
        Me.txtNumberOfMiles.TabIndex = 6
        Me.txtNumberOfMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostOfRental
        '
        Me.lblTotalCostOfRental.AutoSize = True
        Me.lblTotalCostOfRental.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOfRental.Location = New System.Drawing.Point(106, 300)
        Me.lblTotalCostOfRental.Name = "lblTotalCostOfRental"
        Me.lblTotalCostOfRental.Size = New System.Drawing.Size(156, 20)
        Me.lblTotalCostOfRental.TabIndex = 7
        Me.lblTotalCostOfRental.Text = "Total Cost of Rental :"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(281, 300)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalCost.TabIndex = 8
        '
        'displayFare
        '
        Me.displayFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayFare.Location = New System.Drawing.Point(87, 338)
        Me.displayFare.Name = "displayFare"
        Me.displayFare.Size = New System.Drawing.Size(93, 23)
        Me.displayFare.TabIndex = 9
        Me.displayFare.Text = "Display Fare"
        Me.displayFare.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.Transparent
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(186, 338)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(93, 23)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(285, 338)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(93, 23)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'frmSmartCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(448, 373)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.displayFare)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostOfRental)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.lblNumberOfMiles)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.carRentalImage)
        Me.Name = "frmSmartCar"
        Me.Text = "Rent A Smart Car"
        CType(Me.carRentalImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents carRentalImage As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblNumberOfMiles As Label
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents lblTotalCostOfRental As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents displayFare As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
