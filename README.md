# Actio
Actio trainning by PacktPub Course ".NET Core Microservices".

#Readme more about issues encounter during the development.

"Fiddler TLS Issues. Failed to negotiate HTTPS"
When I am running with Fiddler in HTTPS I have 502 HTTP error. It's about negociation in HTTPS.
https://developers.de/2018/08/30/fiddler-tls-issues/

"Using .netcore 2.2 and using the "In Process" Hosting Model"
This errors occurred running directly in Visual Studio.
https://stackoverflow.com/questions/53811569/using-netcore-2-2-and-using-the-in-process-hosting-model

"RawRabbit.Pipe NameSpace"
Follow the Ghini Antonio's anwser I changed UseConsumerConfiguration method to UseSubscribeConfiguration in rc-5 from RawRabbit.
https://stackoverflow.com/questions/49367550/rawrabbit-pipe-namespace

"JsonSerializer System.MissingMethodException"
This error ocorred in POST to activities URL. Only updating the release candidate of RawRabbit library works. 
https://github.com/pardahlman/RawRabbit/issues/327
