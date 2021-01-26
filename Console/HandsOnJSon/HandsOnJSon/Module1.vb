Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json
Module Module1
    Public Sub GetAll()
        Dim client As New HttpClient
        client.BaseAddress = New Uri("http://localhost:5000/")
        Dim contentType As New MediaTypeWithQualityHeaderValue("application/json")
        client.DefaultRequestHeaders.Accept.Add(contentType)
        Dim response As HttpResponseMessage = client.GetAsync("api/Product/GetAll").Result
        Dim list As List(Of Product) = JsonConvert.DeserializeObject(Of List(Of Product))(response.Content.ReadAsStringAsync().Result)
        For Each p In list
            Console.WriteLine("{0} {1} {2} {3}", p.Pid, p.Pname, p.Price, p.Stock)
        Next
    End Sub
    Public Sub GetById(id As Integer)
        Dim client As New HttpClient
        client.BaseAddress = New Uri("http://localhost:5000/")
        Dim contentType As New MediaTypeWithQualityHeaderValue("application/json")
        client.DefaultRequestHeaders.Accept.Add(contentType)
        Dim response As HttpResponseMessage = client.GetAsync("api/Product/GetById/" & id).Result
        Dim p As Product = JsonConvert.DeserializeObject(Of Product)(response.Content.ReadAsStringAsync().Result)

        Console.WriteLine("{0} {1} {2} {3}", p.Pid, p.Pname, p.Price, p.Stock)

    End Sub
    Public Sub Add(item As Product)
        Dim client As New HttpClient
        client.BaseAddress = New Uri("http://localhost:5000/")
        Dim contentData As New StringContent(JsonConvert.SerializeObject(item), System.Text.Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = client.PostAsync("api/Product/Add", contentData).Result
        Console.WriteLine(response.Content.ReadAsStringAsync.Result)
    End Sub
    Public Sub Update(item As Product)
        Dim client As New HttpClient
        client.BaseAddress = New Uri("http://localhost:5000/")
        Dim contentData As New StringContent(JsonConvert.SerializeObject(item), System.Text.Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = client.PutAsync("api/Product/Update", contentData).Result
        Console.WriteLine(response.Content.ReadAsStringAsync.Result)
    End Sub
    Public Sub Delete(id As Integer)
        Dim client As New HttpClient
        client.BaseAddress = New Uri("http://localhost:5000/")
        Dim response As HttpResponseMessage = client.DeleteAsync("api/Product/Delete/" & id).Result
        Console.WriteLine(response.Content.ReadAsStringAsync.Result)

    End Sub
    Sub Main()
        'Add(New Product() With {.Pid = 4, .Pname = "ABBB", .Price = 100, .Stock = 10})
        ' Delete(4)
        Update(New Product() With {.Pid = 1, .Pname = "Keyboard", .Price = 1000, .Stock = 10})
        GetAll()
        Console.WriteLine(vbNewLine)
        'GetById(1)

    End Sub

End Module
