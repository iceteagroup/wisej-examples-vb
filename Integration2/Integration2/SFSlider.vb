Imports System.Collections.Generic
Imports System.ComponentModel
Imports Wisej.Core
Imports Wisej.Web

Public Class SFSlider
    Inherits Widget
    ''' <summary>
    ''' Overridden to return our list of script resources.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides ReadOnly Property Packages As List(Of Package)
        Get

            If MyBase.Packages.Count = 0 Then
                ' initialize the loader with the required libraries.

                MyBase.Packages.AddRange(New Package() {New Package() With {
                    .Name = "ej.web.all.min.css",
                    .Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css"
                }, New Package() With {
                    .Name = "jquery-1.10.2.min.js",
                    .Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js"
                }, New Package() With {
                    .Name = "jquery.easing.1.3.min.js",
                    .Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js"
                }, New Package() With {
                    .Name = "ej.web.all.min.js",
                    .Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js"
                }})
            End If

            Return MyBase.Packages
        End Get
    End Property

    ''' <summary>
    ''' Overridden to create our initialization script.
    ''' </summary>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property InitScript As String
        Get
            Return BuildInitScript()
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Private Function BuildInitScript() As String
        Dim options As DynamicObject = New DynamicObject()
        Dim script = $"this.init = function() {{
		        var me = this;
		        $(this.container).ejSlider ({{
			        minValue: 1,
			        maxValue: 25,                                    
			        incrementStep: 1,
			        value: {Value},
			        change: function(e){{ me.fireWidgetEvent(""change"", e.value); }}
	                   }});
		         }};

            this.setValue = function(value){{
	            $(this.container).ejSlider({{value:value}});
                 }};

            "
        script = script.Replace("$options", options.ToString())
        Return script
    End Function

    Public Value As Integer
End Class
