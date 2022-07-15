Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Moq
Imports SubscriptionApp

Namespace TestSubscriptionApp
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Sub TestSub()
            'Dim e As Empresa = New Empresa(1, "prova", 5)
            Dim mock As Mock(Of SubsToBusinessRepository)
            mock.Setup(Sub(x) x.Add(1, 2))

        End Sub
    End Class
End Namespace

