Imports System.Collections.Generic

Namespace Model
    Public Class TherapistList
        Inherits List(Of Therapist)

        Private Shared _therapistList As TherapistList

        Private Sub New()
        End Sub

        Public Shared Function Instance() As TherapistList
            If _therapistList Is Nothing Then CreateAndPopulate()
            Return _therapistList
        End Function

        Private Shared Sub CreateAndPopulate()
            _therapistList = New TherapistList From {
                New Therapist With {
                    .TherapistName = "Dr. Lucius Livius Andronicus",
                    .TherapyId = 1
                },
                New Therapist With {
                    .TherapistName = "Dr. Gnaeus Naevius",
                    .TherapyId = 1
                },
                New Therapist With {
                    .TherapistName = "Dr. Quintus Ennius",
                    .TherapyId = 1
                },
                New Therapist With {
                    .TherapistName = "Dr. Marcus Pacuvius",
                    .TherapyId = 2
                },
                New Therapist With {
                    .TherapistName = "Dr. Lucius Accius",
                    .TherapyId = 3
                },
                New Therapist With {
                    .TherapistName = "Dr. Titus Maccius Plautus",
                    .TherapyId = 3
                },
                New Therapist With {
                    .TherapistName = "Dr. Publius Terentius Afer (Dr. Terence)",
                    .TherapyId = 4
                },
                New Therapist With {
                    .TherapistName = "Dr. Marcus Porcius Cato (Dr. Cato the Elder)",
                    .TherapyId = 5
                },
                New Therapist With {
                    .TherapistName = "Dr. Gaius Lucilius",
                    .TherapyId = 5
                },
                New Therapist With {
                    .TherapistName = "Dr. Marcus Tullius Cicero",
                    .TherapyId = 5
                },
                New Therapist With {
                    .TherapistName = "Dr. Publius Ovidius Naso (Dr. Ovid)",
                    .TherapyId = 5
                },
                New Therapist With {
                    .TherapistName = "Dr. Gaius Valerius Catullus",
                    .TherapyId = 5
                }
            }
        End Sub
    End Class
End Namespace
