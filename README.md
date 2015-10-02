# JaycarPowerMeterMS6174
A different interface for the Jaycar usb interface MS6174 for the Digital Power Meters (such as MS6172)
## Details
* Lets you view the current Voltage,Power,Current readings over serial (automatically updates at 2Hz)
* Lets you download the data from the unit into a csv file
* Shows the data in a table view for easy double-checking


##Hardware
This program works with the official Jaycar hardware, and has been tested with a MS6172.
It is also worth noting that the MS6174 converter is just a CP2012 UART<-> USB converter with a 2.5mm output jack (tip=rx,ring=tx,sleeve=GND -> tx/rx could be other way around, only going by silkscreen)
When i bought my unit i could not manage to connect to it, upon investigation the 2.5mm jack cable had Tx and Rx shorted together, remaking this cable with better quality materies fixed the issue.
###Licence
The code is currently licenced under "GNU GENERAL PUBLIC LICENSE v3".
If you wish to use this code under other licences please contact me :)