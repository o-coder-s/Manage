using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Manage.Repository
{
    public class Request
    {

        public string BaseUrl { get; set; } = "http://127.0.0.1:30001/";

        public async Task<T> Get<T>(string route)
        {
            T data;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var response = await client.GetAsync(route);
                data = await response.Content.ReadAsAsync<T>();
            }
            return data;
        }

        public async Task<IEnumerable<T>> GetAll<T>(string route)
        {
            IEnumerable<T> data;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var response = await client.GetAsync(route);
                data = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }
            return data;
        }

        public async Task<HttpResponseMessage> Delete<T>(string route)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                response = await client.DeleteAsync(route);
            }
            return response;
        }

        public async Task<HttpResponseMessage> Post<T>(T data, string route)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                response = await client.PostAsJsonAsync<T>(route, data);
            }
            return response;
        }
        public async Task<HttpResponseMessage> Put<T>(T data, string route)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                response = await client.PutAsJsonAsync<T>(route, data);
            }
            return response;
        }
    }
}
