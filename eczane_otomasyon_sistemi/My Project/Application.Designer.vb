﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Bu kod araç tarafından oluşturuldu.
'     Çalışma Zamanı Sürümü:4.0.30319.42000
'
'     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
'     kod yeniden oluşturulursa kaybolur.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'NOT: Bu dosya otomatik olarak oluşturulur; doğrudan değiştirmeyin.  Değişiklik yapmak için,
    ' veya bu dosyada derleme hatalarıyla karşılaşırsanız, Proje Tasarımcısı'na gidin
    ' (Proje Özellikleri'ne gidin veya Çözüm Gezgini içerisindeki
    ' Projelerim düğümüne çift tıklayın) ve Uygulama sekmesinde değişiklikler yapın.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.eczane_otomasyon_sistemi.girisPanel
        End Sub
    End Class
End Namespace
