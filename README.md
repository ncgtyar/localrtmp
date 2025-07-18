# localrtmp
Read frames from a local RTMP stream using OpenCVSharp
- **Encoding must be H.264** *(This is default in OBS)*

**Required NuGet packages:**
1) OpenCVSharp4
2) OpenCVSharp4.runtime.win
3) OpenCVSharp4.Extensions
4) System.Drawing

**Required libraries:**
1) nginx *(RTMP server)*
- *Extract to any directory, cd to it and run nginx.exe with the port set to 1935 in the config*
- *Note: nginx must keep running or your streaming program will fail to open the stream*
- You don't need nginx if your program handles the server by itself

**Stream URL example:**
1) URL: rtmp://localhost/live
2) Stream key: mystream (any string)
3) Full URL: rtmp://localhost/live/mystream
- *Note: if you're using a port different than 1935 (which is the default) you must specify it*
- *Example: localhost:1234/live*

**OBS tutorial + example:**
1) Settings
2) Stream
3) Service: Custom
4) Server: rtmp://localhost/live
5) Stream key: mystream
- *OBS automatically compiles the two strings*
