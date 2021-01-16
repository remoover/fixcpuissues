Hello,

We have application that will recording http stream into an file

We need run it running this application ONLY on LINUX !

On windows it was getting 0% CPU on LINUX it getting 50%+ CPU becasue of infinite loop.. but we need use infinite loop.

Please fix this code so it will be nonstop getting data without any loose and target of CPU will be always 0%(same as on windows)

this application are in C# and we need run on LINUX via MONO

Instead Visual Studio u need install Rider from Jet Brains... 30days trial working and its same like Visual Studio.. how to work with Rider, check picture HowToRider.png

Requirements:
Install Debian or Ubuntu DESKTOP VERSION --> u can also try via virtualbox, etc...

for Debian 10 DESKTOP VERSION follow:

sudo apt install apt-transport-https dirmngr
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/debian vs-buster main" | sudo tee /etc/apt/sources.list.d/mono-official-vs.list
sudo apt update
sudo apt-get install monodevelop

#to check CPU usage install htop and with F4 you can filter.. type: cpuissue   //so you can follow CPU usage
sudo apt-get install htop

#install Rider then normally open .sln 
sudo apt update
sudo apt install snapd
sudo snap install core
sudo snap install rider --classic

# start exe file under linux
mono cpuissues.exe



Target:
0% CPU ... same as recording with ffmpeg or vlc... but we need use this method as u see in code...

DONE
=============================
https://www.monodevelop.com/download/#fndtn-download-lin-debian
https://snapcraft.io/install/rider/debian#install
