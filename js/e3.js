define(["analyser","util"],function(a,b){function c(){h.save();var b=0,c=k;f=a.getData(),h.clearRect(0,0,g.width,g.height);for(var d=0;d<f.length;d++)b+=f[d];k=b/f.length;for(var e=k-c,l=Math.abs(e),d=0,m=i.length;m>d;d+=2){var n=i[d];e>0?(n.r+=l/10,n.r>n.maxR&&(n.r-=(n.r-n.maxR)/5),n.o+=.05,n.o>1&&(n.o=1)):(n.r-=l/5,n.r<0&&(n.r=.01),n.r<n.minR&&(n.r+=(n.minR-n.r)/10),n.o-=.05,n.o<n.minO&&(n.o=n.minO)),j+=1e-4,n.y+=Math.cos(j+n.d)-2,n.x+=Math.sin(j+n.d),n.x>g.width+5?(n.x=-5,n.d=50*Math.random()):n.x<-5?(n.x=g.width+5,n.d=50*Math.random()):n.y<0&&(n.y=g.height+5,n.d=50*Math.random());var o=h.createRadialGradient(n.x,n.y,2,n.x,n.y,n.r+3);o.addColorStop(0,"rgba(255, 255, 255, "+n.o+")"),o.addColorStop(1,"rgba("+n.c+", 0)"),h.fillStyle=o,h.beginPath(),h.moveTo(n.x,n.y),h.arc(n.x,n.y,n.r+3,0,2*Math.PI,!0),h.closePath(),h.fill()}var p=g.width/2,q=g.height,r=5*k;o=h.createRadialGradient(p,q,r/8,p,q,r),o.addColorStop(0,"rgba(175, 221, 255, 0.5)"),o.addColorStop(1,"rgba(76, 159, 219, 0)"),h.fillStyle=o,h.beginPath(),h.arc(p,q,r,0,2*Math.PI,!0),h.closePath(),h.fill(),h.restore()}function d(){b.setBg(3);for(var c=a.getFftSize()/2,d=g.width,e=g.height,f=l.length,h=0;c>h;h++)i[h]={x:Math.random()*d,y:Math.random()*e,r:5*Math.random(),minR:5*Math.random()+1,maxR:12*Math.random()+5,d:50*Math.random(),c:l[b.intRandom(0,f)]},i[h].minO=i[h].o=.8*Math.random()+.2;m=!0}function e(){return m}var f,g=b.getById("visual-canvas"),h=g.getContext("2d"),i=[],j=0,k=0,l=["105, 210, 231","255, 255, 255","248, 37, 77","248, 225, 16"],m=!1;return{draw:c,init:d,isInit:e}});