
function printTime() {
    var d = new Date();
    
      postMessage(d);
      setTimeout("printTime()",500);
    
  }
  
printTime();