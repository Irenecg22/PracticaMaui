using MauiPractica.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace MauiPractica.Services
{
    public class EmpleadoService
    {
        HttpClient _client = new();
        JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        Uri uri = new Uri(string.Format("http://127.0.0.1:8000/empleados/"));


        public async Task<List<Empleado>> GetAllAsync()
        {
            var items = new List<Empleado>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<List<Empleado>>(content, _jsonSerializerOptions);
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