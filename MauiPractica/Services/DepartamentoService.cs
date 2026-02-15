using MauiPractica.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace MauiPractica.Services
{
    public class DepartamentoService
    {
        HttpClient _client = new();
        JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        Uri uri = new Uri(string.Format("http://127.0.0.1:8000/departamentos/"));


        public async Task<List<Departamento>> GetAllAsync()
        {
            var items = new List<Departamento>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<List<Departamento>>(content, _jsonSerializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return items;
        }
    }
}
