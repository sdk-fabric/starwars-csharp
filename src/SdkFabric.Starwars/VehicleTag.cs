/**
 * VehicleTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Starwars;

public class VehicleTag : TagAbstract {
    public VehicleTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Get all the vehicles
     */
    public async Task<VehicleCollection> GetAll(string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/vehicles", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<VehicleCollection>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }
    /**
     * Get a specific vehicle
     */
    public async Task<Vehicle> Get(string id)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("id", id);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/vehicles/:id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<Vehicle>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }


}
