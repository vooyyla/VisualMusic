define(["analyser","util"],function(a,b){function c(){for(n.save(),f=a.getData(),k=o,i=m.width/2,j=m.height/2,n.clearRect(0,0,m.width,m.height),n.globalCompositeOperation="lighter",n.strokeStyle=r,n.lineWidth=10,l=0,g=12;h>g;g+=2)k+=.2,n.beginPath(),n.moveTo(i+f[g]*Math.sin(k),j+f[g]*Math.cos(k)),n.lineTo(i+f[g]*Math.sin(k+q),j+f[g]*Math.cos(k+q)),n.lineTo(i+f[g]*Math.sin(k+2*q),j+f[g]*Math.cos(k+2*q)),n.closePath(),n.stroke(),l+=f[g];o=(o+1e-5*l)%p,n.restore()}function d(){b.setBg(7),initOrNot=!0}function e(){return initOrNot}var f,g,h,i,j,k,l,m=b.getById("visual-canvas"),n=m.getContext("2d"),o=0,h=a.getFftSize()/16,p=2*Math.PI,q=p/3,r="rgba(186, 135, 72, 0.5)";return initOrNot=!1,{draw:c,init:d,isInit:e}});