'http://codereview.stackexchange.com/questions/39163/loading-a-combobox-with-an-enum-and-binding-to-it

Imports System
Imports System.ComponentModel
Imports System.Linq
Imports System.Reflection
Imports Wisej.Web
Imports System.Runtime.CompilerServices

Namespace DataBinding.Model
    Friend Module EnumExtension

        ' Not used in the project
        ' public static void EnumToComboBox(this ComboBox comboBox, Type enumType)
        ' {
        ' comboBox.DataSource = Enum.GetValues(enumType).Cast<Enum>().Select(Key => new
        ' {
        ' (Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
        ' typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
        ' Key
        ' }).OrderBy(item => item.Key).ToList();
        ' 
        ' comboBox.DisplayMember = "Description";
        ' comboBox.ValueMember = "Key";
        ' }


        <Extension()>
        Public Sub EnumToDataSource(ByVal bindingSource As BindingSource, ByVal enumType As Type)


            'TODO - FIX syntax LinQ

            'bindingSource.DataSource = [Enum].GetValues(enumType).Cast(Of System.Enum).Select((Function(Key) Key.GetDescription))

            'bindingSource.DataSource = [Enum].GetValues(enumType).Cast(Of System.Enum).Select(
            '                                    (Function(Key) New With {Key .Description = "Hugo Garcia",
            '                                                             Key .Key = "Louisville"}
            '                                    ))

            bindingSource.DataSource = [Enum].GetValues(enumType).Cast(Of System.Enum).Select(
                                                (Function(Key) New With {Key .Description = Key.GetDescription,
                                                                         Key .Key = Key}
                                                )).OrderBy(Function(item) item.Key).ToList()


            'bindingSource.DataSource = [Enum].GetValues(enumType).Cast(Of System.Enum).Select((Function(Key) New With
            '                           {TryCast(Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
            '                            GetType(DescriptionAttribute)), DescriptionAttribute).Description, Key _
            '                            }))


            'bindingSource.DataSource = System.Enum.GetValues(enumType).Cast(Of System.Enum).Select((Function(Key) New _
            '    With {Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
            '           GetType(DescriptionAttribute)), DescriptionAttribute).Description, Key }.OrderBy(Function(item) item.Key).ToList()



            'TODO Fix error conversion from C#
            'bindingSource.DataSource = [Enum].GetValues(enumType).Cast(Of [Enum])().[Select](Function(Key) New _
            '    With {TryCast(Attribute.GetCustomAttribute(Key.GetType().GetField(Key.ToString()),
            '                  GetType(DescriptionAttribute)), DescriptionAttribute).Description, Key }).OrderBy(Function(item) item.Key).ToList()


        End Sub

        <Extension()>
        Public Function GetEnumForBind(ByVal bindingSource As BindingSource, ByVal enumeration As Type) As Hashtable
            Dim names As String() = [Enum].GetNames(enumeration)
            Dim values As Array = [Enum].GetValues(enumeration)

            Dim ht As New Hashtable()
            For i As Integer = 0 To names.Length - 1
                ht.Add(values.GetValue(i), names(i))
            Next
            Return ht
        End Function


        ' should be used to feed the AutoCompleteCustomSource
        Public Function EnumToArray(ByVal enumType As Type) As String()
            Return (From item In [Enum].GetValues(enumType) Select
                TryCast(Attribute.GetCustomAttribute(item.GetType().GetField(item.ToString()),
                        GetType(DescriptionAttribute)), DescriptionAttribute).Description).ToArray()
        End Function

        ' https://stackoverflow.com/questions/20290842/converter-to-show-description-of-an-enum-and-convert-back-to-enum-value-on-sele

        <Extension()>
        Public Function GetDescription(ByVal value As [Enum]) As String
            Dim type As Type = value.GetType()
            Dim memInfo As MemberInfo() = type.GetMember(value.ToString())

            If memInfo IsNot Nothing AndAlso memInfo.Length > 0 Then
                Dim attrs = memInfo(0).GetCustomAttributes(GetType(DescriptionAttribute), False)

                If attrs IsNot Nothing AndAlso attrs.Length > 0 Then
                    Return CType(attrs(0), DescriptionAttribute).Description
                End If
            End If

            Return value.ToString()
        End Function
    End Module
End Namespace
