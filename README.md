Active Directory Impersonator
=========

A quick and simple way to debug ASP.NET impersonation against Active Directory
and also serves as reference material as to how to implement this
functionality.

Requirements:

* .NET 4.0
* IIS 6.x+
* Active Directory


Usage
---
Configure the account details (domain,username,password) within the Web.config:

    <!-- Application Settings -->
    <appSettings>
        <add key="adDomain" value="test-domain"/>
        <add key="adUsername" value="svc_serviceaccount"/>
        <add key="adPassword" value="password"/>
    </appSettings>

Navigate to https://iis/webroot/debug.aspx and observe the results:

    ASP.NET running as: ghuntley
    Authenticated as: test-domain\ghuntley
    ASP.NET (after impersonation) running as: svc_serviceaccount
    Authenticated (after impersonation) as: test-domain\ghuntley

Notes
---
Identify impersonation needs to be enabled within Web.Config; without this everything falls apart. Refer to the MSDN [documentation](http://msdn.microsoft.com/en-us/library/aa292118(v=vs.71).aspx).

    <system.web>
      <identity impersonate="true"/>
    </system.web>

If your more of a visual person, try running debug.aspx with the following combinations to truely gain an understanding as to how it all glues together: 

* IIS anonymous authentication ON & identity impersonate="true"
* IIS anonymous authentication ON & identity impersonate="false"
* IIS anonymous authentication OFF, IIS basic/digest ON & identity impersonate="true"
* IIS anonymous authentication OFF, IIS basis/digest ON & identity impersonate="false"

License
---
Copyright 2011 Geoffrey Huntley. All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted - no strings attached.

