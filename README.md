# The Barry HTTP Server - NOPE, THAT'S TOO UNSECURE

![barry-unauthorized](https://user-images.githubusercontent.com/141124/37240059-826ed7ca-23fa-11e8-877f-61db75d50e61.jpg)

## Overview
Are you insecure about being unsecure? Do you think ALL HTTP requests are invalid? 

If you answered yes to any of these, you need the Barry HTTP server. 
## How it works

All requests MUST be returned with a `403 UNAUTHORIZED` status.

## FAQ

### Routes?
Nope, that's too unsecure

### Any middleware support?
Nope, that's too unsecure

### OAuth?
Nope, that's too unsecure

### Content Negotiation?
Though all HTTP is inherently unsecure, Barry HTTP will honor different HTTP clients including browsers, `application/json`, and `text/plain`, see screenshots below:

*text/plain*

<img width="600" src="https://user-images.githubusercontent.com/141124/37240085-fdfcd6ee-23fa-11e8-9eaa-f658fc808455.png"/>

*application/json*

<img width="600" src="https://user-images.githubusercontent.com/141124/37240088-06ace59a-23fb-11e8-9a34-56ea07fc129f.png"/>

*Everything else*

<img width="600" src="https://user-images.githubusercontent.com/141124/37240400-83e9ac74-23ff-11e8-88e2-b3ff8a9176e4.png"/>

### Do you accept Pull Requests?
Depends on if it is unsecure nor not. Changing the return status code is considered unsecure.

## License
Apache 2.0

  
