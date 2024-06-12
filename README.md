1. I really enjoyed learning how to install dapper and asp.net 8.0 controllers. They are vastly improved from previous versions
2. I really wanted to implement a Command Pattern structure and the MediatR Pattern, but I was running out of time and had to abandon the idea
    The result was half baked classes to place the logic and repo calls
3. I would have really loved to have better organized the solution. The namings aren't good, large part because I was in a hurry with the clock ticking.
    Usually I would try to organize the names to give clear meaning and the interfaces would appear on top or bottom of their counter part objects.
4. I was around 20 minutes over, and the additional Task of Reservations expiring after 30 minutes. I anticipate this would be taking longer then 30 minutes to resolve,
    plus testing
5. I was really having a hard time thinking of a good way to do it within this API without creating another endpoint that would need to be hit manually every 15 minutes. I'm confident
    a lamba function or azure function would be well suitable. Something that just runs every 15 minuts, scanning the Updated_DT column (or a new column for it specifically
    would even be better. Perhaps Reserved_DT column. Considering the point of the API was is took book appointments as a manual process, it seems justified. However,
    perhaps theres some tooling in the controller API that im unaware of that would allow a code block to run which is executed by time which would allow the concept to fit right in.
5. Thank you for this oppurtunity. I really enjoyed getting back into .NET and taking on the idea of a light weight API, and learning the new technologies. Its far better then VS 2019 and prior
