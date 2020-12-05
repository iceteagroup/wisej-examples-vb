Imports System
Imports Wisej.Web

Partial Public Class Page1

    Public Sub New()
        InitializeComponent()
        AddHandler pannellum1.WidgetEvent, AddressOf Pannellum1_WidgetEvent
    End Sub

    Private Sub Pannellum1_WidgetEvent(ByVal sender As Object, ByVal e As WidgetEventArgs)
        If Equals(e.Type, "hotspot") Then AlertBox.Show(e.Data.text)
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        pannellum1.Options = New With {
            .type = "equirectangular",
            .autoLoad = True,
            .panorama = "https://pannellum.org/images/alma.jpg"
        }
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        pannellum1.Options = New With {
            .type = "equirectangular",
            .autoLoad = True,
            .autoRotate = -2,
            .panorama = "https://pannellum.org/images/alma.jpg"
        }
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        pannellum1.Options = New With {
            .type = "cubemap",
            .autoLoad = True,
            .cubeMap = {"https://pannellum.org/images/wyman-park-playground-cubic/face0.jpg", "https://pannellum.org/images/wyman-park-playground-cubic/face1.jpg", "https://pannellum.org/images/wyman-park-playground-cubic/face2.jpg", "https://pannellum.org/images/wyman-park-playground-cubic/face3.jpg", "https://pannellum.org/images/wyman-park-playground-cubic/face4.jpg", "https://pannellum.org/images/wyman-park-playground-cubic/face5.jpg"}
        }
    End Sub

    Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
        pannellum1.Options = New With {
            .type = "equirectangular",
            .autoLoad = True,
            .autoRotate = -2,
            .panorama = "https://pannellum.org/images/bma-1.jpg",
            .hotSpots = New Object() {New With {
                .pitch = 14.1,
                .yaw = 1.5,
                .type = "info",
                .text = "Baltimore Museum of Art",
                .url = "https://artbma.org/"
            }, New With {
                .pitch = -9.4,
                .yaw = 222.6,
                .type = "info",
                .text = "Art Museum Drive"
            }, New With {
                .pitch = -0.9,
                .yaw = 144.4,
                .type = "info",
                .text = "North Charles Street"
            }}
        }
    End Sub

    Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
        pannellum1.Options = New With {
            .type = "multires",
            .autoLoad = True,
            .multiRes = New With {
                .basePath = "https://pannellum.org/images/multires/library",
                .path = "/%l/%s%y_%x",
                .fallbackPath = "/fallback/%s",
                .extension = "jpg",
                .tileResolution = 512,
                .maxLevel = 6,
                .cubeResolution = 8432
            }
        }
    End Sub
End Class
