/**
 * PeopleTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Starwars;

public class PeopleTag : TagAbstract {
    public PeopleTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<PeopleCollection> GetAll(string name)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("name", name);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/people", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<PeopleCollection>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<People> Get(string id)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("id", id);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/people/:id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<People>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}