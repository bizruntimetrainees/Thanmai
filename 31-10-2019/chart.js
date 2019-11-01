 d3.selectAll("p")
.style("color","blue");

const canvas = d3.select(".canva");
var dataArray =[4,15,10,20,50];

const svg = canvas.select("svg");
const rect =svg.selectAll("rect");
rect.data(dataArray);
rect.enter().append("rect")
rect.attr("height",function(d){return d*2});
rect.attr("width",24);
rect.attr("fill","purple")
rect.attr("x",function(d,i)  { return i*35 ;}  )
rect.attr("y",function(d,i)  { return 100-(d*2);}  )





