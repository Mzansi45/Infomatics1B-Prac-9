Option Strict On
Option Explicit On
Option Infer Off
'************************************************
'Surname Initials: Gulube T
'Student Number: 219020988
'Practical: P2020A-09
'Class Name:
'************************************************

Public Class FrmF2H
    'these are my variable declerations
    Private regions As Integer
    Private months As Integer
    Private provinces As Integer
    Private province() As ProvinceRec

    Private Structure RegionRec  'record structure for each region
        Public LeaderName As String
        Public nClinics As Integer
        Public Month() As Integer
        Public totalVisitors As Integer
        Public ClinicRatio As Double
    End Structure
    Private Structure ProvinceRec   'rechord structure for each province
        Public name As String
        Public region() As RegionRec
        Public max As Integer
    End Structure

    Private Sub inputPRM()
        'these are the primary inputs  they are compalsory for app to work
        provinces = CInt(InputBox("Number of Provinces", "Mem"))
        regions = CInt(InputBox("Number of regions", "Mem"))
        months = CInt(InputBox("Number of months", "Mem"))
    End Sub
    'the sub below helps me label the grid
    Private Sub LG(ByVal c As Integer, ByVal r As Integer, ByVal t As String)
        grid1.Col = c
        grid1.Row = r
        grid1.Text = t
    End Sub

    Private Sub ResizeAll() ' this sub is not only for resizing but for labelling the grid as well

        grid1.Cols = regions + 2
        grid1.Rows = provinces + 1

        ReDim province(provinces)
        For p As Integer = 1 To provinces
            ReDim province(p).region(regions)
            For r As Integer = 1 To regions
                ReDim province(p).region(r).Month(months)
            Next
        Next

        LG(0, 0, "Province Name")
        LG(regions + 1, 0, "Busiest region")
        For p As Integer = 1 To provinces
            LG(0, p, "Province " & CStr(p))
        Next p

        For r As Integer = 1 To regions
            LG(r, 0, "Reg" & CStr(r) & " clinic Ratio")
        Next
    End Sub

    Private Sub CalcTotal(ByVal number As Integer, ByRef size As Integer) ' with this sub i can calculate any total
        size += number
    End Sub

    Private Sub UserInput() 'all data will be captured here in this sub
        For p As Integer = 1 To provinces
            province(p).name = InputBox("Name of province " & CStr(p))
            For r As Integer = 1 To regions
                province(p).region(r).LeaderName = InputBox("Please enter the name of the leader of region " & CStr(r) & " in " & province(p).name)
                province(p).region(r).nClinics = CInt(InputBox("Number of Clinics in region " & CStr(r) & " in " & province(p).name))
                For m As Integer = 1 To months
                    province(p).region(r).Month(m) = CInt(InputBox("Please enter the number of Patients in Region " & CStr(r) & " Month " & CStr(m) & province(p).name))
                Next m
            Next r
            LG(0, p, province(p).name)
        Next p
    End Sub

    Private Sub Total() 'the total number of patients
        For p As Integer = 1 To provinces
            For r As Integer = 1 To regions
                For m As Integer = 1 To months
                    CalcTotal(province(p).region(r).Month(m), province(p).region(r).totalVisitors)
                Next m
            Next r
        Next p
    End Sub

    Private Sub clinicRatio() ''this sub helps me calculate the clinic ratio 
        For p As Integer = 1 To provinces
            For r As Integer = 1 To regions
                Select Case province(p).region(r).nClinics
                    Case 0 To 12
                        province(p).region(r).ClinicRatio = province(p).region(r).totalVisitors / months
                    Case 13 To 25
                        province(p).region(r).ClinicRatio = province(p).region(r).totalVisitors / 10
                    Case > 25
                        province(p).region(r).ClinicRatio = province(p).region(r).totalVisitors / 20
                End Select
                LG(r, p, CStr(province(p).region(r).ClinicRatio)) 'grid label
            Next r
        Next p
    End Sub

    Private Sub BestRegion() 'under this sub i calculate the busiest region using a select case
        For p As Integer = 1 To provinces
            Dim best As Integer
            best = CInt(province(p).region(1).ClinicRatio)
            province(p).max = 1
            For r As Integer = 1 To regions
                Select Case best
                    Case < CInt(province(p).region(r).ClinicRatio)
                        best = CInt(province(p).region(r).ClinicRatio)
                        province(p).max = r
                End Select
            Next r
            LG(regions + 1, p, province(p).region(province(p).max).LeaderName) ' grid label
        Next p

    End Sub

    'the following code has a lot of button clicks. this is where all my subs work
    Private Sub btnInitialize_Click(sender As Object, e As EventArgs) Handles btnInitialize.Click
        inputPRM()
        ResizeAll()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        UserInput()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Total()
        clinicRatio()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        BestRegion()
    End Sub

End Class

