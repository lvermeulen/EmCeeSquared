![Icon](http://i.imgur.com/ouLOkaz.png?1) 
# EmCeeSquared [![Build status](https://ci.appveyor.com/api/projects/status/lkr8087vbafj5maa?svg=true)](https://ci.appveyor.com/project/lvermeulen/emceesquared) [![license](https://img.shields.io/github/license/lvermeulen/emceesquared.svg?maxAge=2592000)](https://github.com/lvermeulen/EmCeeSquared/blob/master/LICENSE) [![Join the chat at https://gitter.im/lvermeulen/EmCeeSquared](https://badges.gitter.im/lvermeulen/EmCeeSquared.svg)](https://gitter.im/lvermeulen/EmCeeSquared?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) ![](https://img.shields.io/badge/netstandard-1.6-yellowgreen.svg)
EmCeeSquared is an extensible load balancer for service registries (e.g. [Consul](https://github.com/hashicorp/consul)), using [Nanophone](https://github.com/lvermeulen/Nanophone) for service discovery and [Equalizer](https://github.com/lvermeulen/Equalizer) for load balancing.

## Features
* Forwards HTTP requests to a load-balanced instance from **multiple** service registries
* Uses Consul service registry; others can be added with [Nanophone](https://github.com/lvermeulen/Nanophone)
* Uses round robin router by service address; others can be added with [Equalizer](https://github.com/lvermeulen/Equalizer)

##Thanks
* [Dj](https://thenounproject.com/term/dj/430454) icon by [lastspark](https://thenounproject.com/lastspark/) from [The Noun Project](https://thenounproject.com)
