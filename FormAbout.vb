Public Class FormAbout
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelProductName.Text = Application.ProductName
        LabelProductVersion.Text = Application.ProductVersion
        LabelCompany.Text = Application.CompanyName
        LinkLabelWebsite.Text = "https://github.com/grandeljay/XAMPP-Virtual-Hosts"
    End Sub

    Private Sub LinkLabelWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWebsite.LinkClicked
        Process.Start(LinkLabelWebsite.Text)
    End Sub
End Class