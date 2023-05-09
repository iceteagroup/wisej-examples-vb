Imports System
Imports Wisej.Web

Partial Public Class MapPage


    Public Sub New()
        InitializeComponent()
        googleMap1.Packages(0).Source += "&libraries=visualization"
    End Sub

    Private Sub checkBoxMapType_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxMapType.CheckedChanged
        googleMap1.Options.mapTypeControl = checkBoxMapType.Checked
        googleMap1.Update()
    End Sub

    Private Sub checkBoxZoom_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxZoom.CheckedChanged
        googleMap1.Options.zoomControl = checkBoxZoom.Checked
        googleMap1.Update()
    End Sub

    Private Sub checkBoxFullScreen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxFullScreen.CheckedChanged
        googleMap1.Options.fullscreenControl = checkBoxFullScreen.Checked
        googleMap1.Update()
    End Sub

    Private Sub StreetView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxStreetView.CheckStateChanged
        googleMap1.Options.streeViewControl = checkBoxStreetView.Checked
        googleMap1.Update()
    End Sub

    Private Sub checkedListBoxMapType_AfterItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles checkedListBoxMapType.AfterItemCheck
        Dim ids As String() = New String(checkedListBoxMapType.CheckedItems.Count - 1) {}

        For i As Integer = 0 To ids.Length - 1
            ids(i) = checkedListBoxMapType.CheckedItems(i).ToString().ToLowerInvariant()
        Next

        googleMap1.Options.mapTypeControlOptions.mapTypeIds = ids
        googleMap1.Update()
    End Sub

    Private Sub numericUpDownMinZoom_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownMinZoom.ValueChanged
        googleMap1.Options.minZoom = numericUpDownMinZoom.Value
        googleMap1.Update()
    End Sub

    Private Sub numericUpDownMaxZoom_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownMaxZoom.ValueChanged
        googleMap1.Options.maxZoom = numericUpDownMaxZoom.Value
        googleMap1.Update()
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
        googleMap1.Options.zoom = trackBar1.Value
        googleMap1.Update()
    End Sub

    Private Sub buttonAddMarker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAddMarker.Click
        If Not Equals(maskedTextBoxID.Text, "") Then
            maskedTextBoxID.Invalid = False

            If Not Equals(textBoxAddress.Text, "") Then
                googleMap1.AddMarker(maskedTextBoxID.Text, textBoxAddress.Text.Replace(Microsoft.VisualBasic.Constants.vbCrLf, ","))
            Else
                googleMap1.AddMarker(maskedTextBoxID.Text, Double.Parse(maskedTextBoxLat.Text), Double.Parse(maskedTextBoxLng.Text))
            End If
        Else
            maskedTextBoxID.Invalid = True
            MessageBox.Show("Enter the marker's name.", modal:=False, icon:=MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub buttonRemoveMarker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonRemoveMarker.Click
        googleMap1.RemoveMarker(maskedTextBoxID.Text)
    End Sub

    Private Sub buttonClearMarkers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClearMarkers.Click
        googleMap1.ClearMarkers()
    End Sub

    Private Sub googleMap1_MapClick(ByVal sender As Object, ByVal e As Ext.GoogleMaps.MapMouseEventArgs) Handles googleMap1.MapClick
        If Equals(e.Marker, Nothing) Then
            AlertBox.Show("You clicked location: " & e.Location.ToString(), alignment:=Drawing.ContentAlignment.BottomRight)
        Else
            AlertBox.Show("You clicked marker: " & e.Marker & "  at location: " & e.Location.ToString(), alignment:=Drawing.ContentAlignment.TopRight)
        End If
    End Sub

    Private Sub comboBoxMatType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxMapType.SelectedIndexChanged
        googleMap1.Options.mapTypeId = comboBoxMapType.Text.ToLowerInvariant()
        googleMap1.Update()
    End Sub

    Private Sub MapPage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        comboBoxMapType.SelectedIndex = 0
        checkedListBoxMapType.SetItemChecked(0, True)
        checkedListBoxMapType.SetItemChecked(1, True)
        checkedListBoxMapType.SetItemChecked(2, True)
        checkedListBoxMapType.SetItemChecked(3, True)
    End Sub

    Private Sub googleMap1_MapPropertyChanged(ByVal sender As Object, ByVal e As Ext.GoogleMaps.MapPropertyChangedEventArgs) Handles googleMap1.MapPropertyChanged
        Select Case e.Name
            Case "zoom"
                trackBar1.Value = CInt(e.Value)
        End Select
    End Sub

    Private Sub buttonCenterMap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCenterMap.Click
        ' remove the center from the initialization options.
        googleMap1.Options.Delete("center")

        If Not Equals(textBoxAddress.Text, "") Then
            googleMap1.CenterMap(textBoxAddress.Text.Replace(Microsoft.VisualBasic.Constants.vbCrLf, ","))
        Else
            googleMap1.CenterMap(Double.Parse(maskedTextBoxLat.Text), Double.Parse(maskedTextBoxLng.Text))
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        googleMap1.CenterMap(37.774546, -122.433523)
        googleMap1.Eval("
var heatmapData = [
  new google.maps.LatLng(37.782, -122.447),
  new google.maps.LatLng(37.782, -122.445),
  new google.maps.LatLng(37.782, -122.443),
  new google.maps.LatLng(37.782, -122.441),
  new google.maps.LatLng(37.782, -122.439),
  new google.maps.LatLng(37.782, -122.437),
  new google.maps.LatLng(37.782, -122.435),
  new google.maps.LatLng(37.785, -122.447),
  new google.maps.LatLng(37.785, -122.445),
  new google.maps.LatLng(37.785, -122.443),
  new google.maps.LatLng(37.785, -122.441),
  new google.maps.LatLng(37.785, -122.439),
  new google.maps.LatLng(37.785, -122.437),
  new google.maps.LatLng(37.785, -122.435)
];

var heatmap = new google.maps.visualization.HeatmapLayer({
  data: heatmapData
});
heatmap.setMap(this.map);

			")
    End Sub
End Class
