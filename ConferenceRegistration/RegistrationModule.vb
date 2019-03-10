Module RegistrationModule

    ' Registration Options Constants
    Public Const int_CONFERENCE_FEE As Integer = 895
    Public Const int_OPENING_DINNER As Integer = 30
    Public Const int_WORKSHOP_E_COMMERCE As Integer = 295
    Public Const int_WORKSHOP_WEB As Integer = 295
    Public Const int_WORKSHOP_ADV_VISUAL_BASIC As Integer = 395
    Public Const int_WORKSHOP_SECURITY As Integer = 395

    'Public Variables
    Public intTotalRegistrationFee As Integer

    ' Function to determine Total Registration Costs
    Public Function CalcRegistrationCost(ByVal CFee As Boolean,
                                          ByVal CDiner As Boolean,
                                          ByVal CWorkshop As Integer) As Integer

        ' local variable to return total
        Dim total As Integer = 0

        ' If Conference is Checked then add Conference Fee
        ' and check for other fees
        If CFee Then
            total += int_CONFERENCE_FEE

            ' If Opening Dinner is Checked then add Dinner Fee
            If CDiner Then
                total += int_OPENING_DINNER
            End If

            ' Determine which work shop was selected,
            ' if no work shop then no added fees
            Select Case CWorkshop
                Case 1
                    total += int_WORKSHOP_E_COMMERCE
                Case 2
                    total += int_WORKSHOP_WEB
                Case 3
                    total += int_WORKSHOP_ADV_VISUAL_BASIC
                Case 4
                    total += int_WORKSHOP_SECURITY
            End Select
        End If

        ' return total of fees
        Return total
    End Function

End Module
