# protobuf-demo  

this is for protobuf demo

## Compile proto files  

You can compile the proto files to C# object through below command  

```bash
protoc -I=protos --csharp_out=gen/csharp protos/person.proto
```  

## Test

After run the api, you are able to use [protoman](https://github.com/spluxx/Protoman) to test api.  
