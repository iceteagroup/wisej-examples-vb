Imports System.Collections.Generic

Namespace Model
    Public Class TherapyList
        Inherits List(Of Therapy)

        Private Shared _therapyList As TherapyList

        Private Sub New()
        End Sub

        Public Shared Function Instance() As TherapyList
            If _therapyList Is Nothing Then CreateAndPopulate()
            Return _therapyList
        End Function

        Private Shared Sub CreateAndPopulate()
            _therapyList = New TherapyList From {
                New Therapy With {
                    .TherapyId = 1,
                    .TherapyName = "Acupuncture"
                },
                New Therapy With {
                    .TherapyId = 2,
                    .TherapyName = "Osmotherapy"
                },
                New Therapy With {
                    .TherapyId = 3,
                    .TherapyName = "Prolotherapy"
                },
                New Therapy With {
                    .TherapyId = 4,
                    .TherapyName = "Helminthic Therapy"
                },
                New Therapy With {
                    .TherapyId = 5,
                    .TherapyName = "Physiotherapy"
                }
            }
        End Sub
    End Class
End Namespace
