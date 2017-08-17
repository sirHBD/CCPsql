
Namespace My

        'This class allows you to handle specific events on the settings class:
        ' The SettingChanging event is raised before a setting's value is changed.
        ' The PropertyChanged event is raised after a setting's value is changed.
        ' The SettingsLoaded event is raised after the setting values are loaded.
        ' The SettingsSaving event is raised before the setting values are saved.
        Partial Friend NotInheritable Class MySettings

            Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            'Select Case e.PropertyName
            '    Case "LocalSetting"
            '        If Me.MyLocalConn = True Then
            '        Me("ConnectionString") = My.Settings.LocalSetting
            '        End If
            '    Case "SeverSetting"
            '        If My.Settings.MyLocalConn = False Then
            '        Me("ConnectionString") = My.Settings.ServerSetting
            '        End If
            'End Select
            End Sub

            Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
                If My.Settings.MyLocalConn = True Then
                'Me("ConnectionString1") = My.Settings.LocalSetting
                    'Else
                    'Dim xCompName As String = My.Computer.Name
                    'Select Case xCompName
                    '    Case "BARRYLAPTOP"
                    '    Me("conTMS") = My.Settings.DevSetting
                    '    Case "DOWLING-STUDY"
                    '    Me("conTMS") = My.Settings.ServerSetting
                    'End Select
                End If
            End Sub

        End Class
        End Namespace
    
