Public Class VisoEN
    Public Shared Function path()
        Dim s, l As Integer
        s = CurDir.IndexOf("bin")
        l = CurDir.Length
        Return CurDir().Remove(s, l - s)
    End Function
End Class
