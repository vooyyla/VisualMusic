/*
 * B1: #47a3da
 * B2: #258ecd
 * R1: #f2807e
 */
* {
    margin: 0;
    padding: 0;
    font-family: 微软雅黑;
}

html {
    overflow: hidden;
}

/* 隐藏滚动条 */
::-webkit-scrollbar {
   width: 0;
}

audio::-webkit-media-controls-panel {
    -webkit-appearance:none;
    background-color: #404040;
    box-shadow: 0 0 4px rgba(0, 0, 0, 0.8);
    border-radius: 0;
}

audio::-webkit-media-controls-current-time-display {
    color: #30ABD5;
}

input[type="range"]::-webkit-slider-thumb {
    width: 5px;
    border-radius: 5px;
    background-color: #000;
}

#background{
    width: 100%;
    height: 100%;
    position: fixed;
    left: 0;
    top: 0;
}

#file-list-wrapper, #effect-list-wrapper{
    position: fixed;
    width: 200px;
    top: 0;
    height: 100%;
    background-color: #303030;
    z-index: 5;
}

#file-list-wrapper {
    left: -200px;
    transition: left 0.3s;
    box-shadow: 2px 0 2px rgba(0, 0, 0, 0.5), inset 0 0 5px rgba(255, 255, 255, 0.2);
    border-right: 1px solid;
    border-color: #202020;
}

#effect-list-wrapper {
    right: -200px;
    transition: right 0.3s;
    box-shadow: -2px 0 2px rgba(0, 0, 0, 0.5);
    border-left: 1px solid;
    border-color: #202020;
}

#file-list-wrapper .header, #effect-list-wrapper .header{
    padding: 15px;
    font-size: 20px;
    color: #888;
    text-shadow: 0 0 2px rgba(0, 0, 0, 0.7);
    border-bottom: 1px solid #202020;
    box-shadow: 0 0 5px #000, inset 0 0 5px rgba(255, 255, 255, 0.2);
    text-align: center;
    background-color: #404040;
    cursor: default;
}

#file-list, #effect-list{
    width: 200px;
    overflow-y: auto;
    overflow-x: hidden;
    display: block;
    list-style: none;
    opacity: 0.8;
    max-height: calc(100% - 50px);
}

#effect-list li {
    padding: 15px;
    cursor: pointer;
    transition: background-color 0.3s, -webkit-filter 0.3s;
    -webkit-filter: grayscale(1);
}

#effect-list li:hover {
    background-color: #f0f0f0;
    -webkit-filter: grayscale(0);
}

#effect-list li img {
    vertical-align: middle;
    box-shadow: 0 0 5px rgba(0, 0, 0, 0.8);
}

#file-list li {
    border-bottom: 1px solid #555;
    padding: 15px;
    color: #888;
    font-size: 15px;
    width: 100%;
    cursor: pointer;
    word-break: break-all;
    transition: background-color 0.3s;
    box-sizing: border-box;
    text-shadow: 0 0 2px rgba(0, 0, 0, 0.7);
}

#file-list li:hover {
    background-color: #aaa;
    color: #fff;
    box-shadow: inset -1px 0 2px rgba(255, 255, 255, 0.8);
}

#file-list .playing {
    color: #fff;
    background-color: #30ABD5 !important;
    box-shadow: inset 0 0 3px rgba(0, 0, 0, 1) !important;
}

#fullscreen, #play-mode{
    position: fixed;
    width: 50px;
    height: 50px;
    cursor: pointer;
    opacity: 0.5;
    -webkit-transition: opacity 0.3s;
            transition: opacity 0.3s;
    z-index: 2;
}

#fullscreen:hover, #play-mode:hover{
    opacity: 1;
}

#fullscreen {
    top: 10px;
    right: 10px;
    background-image: url(../img/fullscreen-icon.png);
}

#help {
    position: fixed;
    width: 100%;
    height: 100%;
    background-color: #30ABD5;
    z-index: 10;
}

#help img {
    margin: 0 auto;
    display: block;
}

#help-wrapper {
    position: fixed;
    top: calc(50% + 50px);
    left: 50%;
}

#help-btn {
    position: absolute;
    left: -50px;
    margin: 0 auto;
    width: 100px;
    height: 100px;
    line-height: 100px;
    background-color: #47a3da;
    text-align: center;
    border-radius: 50%;
    color: #fff;
    cursor: pointer;
    font-size: 20px;
    -webkit-animation: helpBtnAnimation 1s linear infinite;
    box-sizing: border-box;
    box-shadow: 0 0 50px rgba(0, 0, 0, 0.5);
    transition: background-color 0.3s;
}

#main-bg {
    position: fixed;
    width: 100%;
    height: 100%;
    background-color: #373939;
    box-shadow: inset 0 0 50px rgba(0, 0, 0, 0.5);
    background-image: -webkit-linear-gradient(rgba(255, 255, 255, 0.1), rgba(255, 255, 255, 0.05), rgba(0, 0, 0, 0));
}

#music {
    position: fixed;
    width: 100%;
    left: 0;
    bottom: 0;
    opacity: 0;
    -webkit-transition: opacity 0.3s;
}

#music:hover {
    opacity: 1;
}

#play-mode {
    top: 10px;
    right: 60px;
    background-image: url(../img/playmode-icon.png);
    z-index: 2;
}

#play-mode.rand {
    background-position: 0 -50px;
}

#play-mode.single {
    background-position: 0 -100px;
}

#song-name {
    position: fixed;
    text-align: center;
    width: 100%;
    padding: 5px 0;
    color: #fff;
    font-size: 30px;
    line-height: 50px;
    height: 50px;
    margin-top: 10px;
    -webkit-text-stroke: 1px #fff;
    text-shadow: -3px 3px 0 #30ABD5;
    opacity: 0;
    top: -50;
}

#song-name.showAndHide {
    -webkit-animation: songNameAnimation 14s linear forwards;
}

#title {
    text-align: center;
    position: absolute;
    width: 100%;
    top: calc(50% - 100px);
    color: #fff;
    height: 100px;
    text-shadow: 0 0 15px rgba(0, 0, 0, 0.8), 0 0 35px rgba(0, 0, 0, 0.8);
    font-size: 40px;
    -webkit-text-stroke: 1px #fff;
    overflow: hidden;
    line-height: 100px;
    cursor: pointer;
}

#visual-canvas, #threed-webgl-renderer, #threed-canvas-renderer{
    position: fixed;
    width: 100%;
    height: 100%;
}

.hidden {
    display: none;
}

.bg0 {
    background-color: #13242f;
    background-image: url(../img/bg0.png), -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0) 20%, #000000 95%);
}

.bg1 {
    background-color: #fff;
    background-image: url(../img/bg1.png);
}

.bg2 {
    background-image: url(../img/bg2.png);
}

.bg3 {
    background-position: center center;
    background-attachment: fixed;
    background-image: url(../img/bg3.jpg);
    -webkit-background-size: cover;
       -moz-background-size: cover;
        -ms-background-size: cover;
    background-size: cover;
}

.bg4 {
    background-color: #815EAD;
    background-image: -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0) 0%, #000000 95%);
}

.bg5 {
    background-color: #fff;
    background-image: -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0) 0%, #000000 95%), url(../img/bg5.png);
}

.bg6 {
    background-color: #fff;
    background-image: url(../img/bg6.png);
}

.bg7 {
    background-color: #21509f;
    background-image: url(../img/bg0.png), -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0) 0%, #000000 95%);
}

.bg8 {
    background-image: -webkit-linear-gradient(#000, rgba(0, 0, 0, 0.5) 20%, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.5) 80%, #000), url(../img/bg8.png);
}

.bg9 {
    background-image: -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0.5) 0%, #000000 100%), url(../img/bg9.png);
}

.bg10 {
    background-image: -webkit-radial-gradient(center, ellipse cover, rgba(0, 0, 0, 0.9) 0%, #000000 100%), url(../img/bg10.jpg);
    background-size: cover;
}

@-webkit-keyframes helpBtnAnimation {
    0% {
        -webkit-transform: scale(1);
        background-color: #f2807e;
    }
    50% {
        -webkit-transform: scale(1.05);
    }
    100% {
        -webkit-transform: scale(1);
    }
}

@-webkit-keyframes songNameAnimation {
    0% {
        opacity: 0;
        -webkit-transform: perspective(400px) rotateX(90deg);
    }
    20% {
        opacity: 1;
        -webkit-transform: perspective(400px) rotateX(0deg);
    }
    80% {
        opacity: 1;
        -webkit-transform: perspective(400px) rotateX(0deg);
    }
    100% {
        opacity: 0;
        -webkit-transform: perspective(400px) rotateX(-90deg);
    }
}
