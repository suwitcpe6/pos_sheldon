Imports Microsoft.Reporting.WinForms

Public Class Frm_Reportviewer


    Dim Reportdata As New model
    Public Event MySubreportEvent(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
    Sub New(val As model)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Reportdata = val
    End Sub
    Public Enum Report_Type
        print = 0
        show = 1
    End Enum
    Private Sub Frm_Reportviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = Center.icon


            If Reportdata.Report_Type = Report_Type.show Then

                If Reportdata.Titletext = "" Then Throw New Exception("ไม่พบ Titletext")
                'If IsNothing(Reportdata.datasouce) Then Throw New Exception("ไม่ได้ใส่ ReportDataSource")
                If IsNothing(Reportdata.datasouce) Then Throw New Exception("ไม่พบ datasouce")
                If Reportdata.ReportPath = "" Then Throw New Exception("ไม่พบ ReportPath")
                'If Reportdata.ReportParameter = "" Then Throw New Exception("ไม่ได้ใส่ Titletext")


                Me.Text = Reportdata.Titletext

                For Each val As datasoucemodel In Reportdata.datasouce
                    'ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource(Reportdata.ReportDataSource, Reportdata.datasouce))
                    ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource(val.ReportData, val.data))
                Next
                ReportViewer1.LocalReport.ReportPath = Reportdata.ReportPath
                ReportViewer1.LocalReport.SetParameters(Reportdata.ReportParameter)

                AddHandler Me.ReportViewer1.LocalReport.SubreportProcessing, AddressOf MySubreportEventHandler
                ReportViewer1.LocalReport.Refresh()
                ReportViewer1.RefreshReport()
                'ReportViewer1.pr


            Else
                'Dim report As New LocalReport()
                'report.ReportPath = Application.StartupPath & Reportdata.ReportPath
                ''report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))
                ''DataTable1TableAdapter.Fill(Me.POReport.DataTable1)
                'report.DataSources.Add(New ReportDataSource(Reportdata.ReportDataSource, Reportdata.datasouce))
                ''report.()
            End If

            'Me.ReportViewer1.RefreshReport
            'Me.ReportViewer1.RefreshReport
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub MySubreportEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        RaiseEvent MySubreportEvent(sender, e)
        'Dim Items_NO As String = e.Parameters(0).Values(0)

        'Dim dt As New DataTable
        'Dim dt2 As New DataTable
        'dt = Reportdata.datasouce(1).data
        'Try
        '    dt2 = dt.Select("Items_NO ='" & Items_NO & "'").CopyToDataTable
        'Catch ex As Exception

        'End Try
        'e.DataSources.Add(New ReportDataSource(Reportdata.datasouce(1).ReportData, dt2))
    End Sub

    Public Class model
        Public Titletext As String
        Public datasouce As New List(Of datasoucemodel)
        Public ReportPath As String
        Public Report_Type As Integer
        Public ReportParameter As New List(Of ReportParameter)
    End Class
    Public Class datasoucemodel
        Public data As Object
        Public ReportData As String
    End Class
    Public Class SubreportModel
        Public subreport As Boolean
        Public column1 As String
        Public column2 As String
        Public column3 As String
    End Class

End Class
