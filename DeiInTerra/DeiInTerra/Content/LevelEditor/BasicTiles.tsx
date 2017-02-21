<?xml version="1.0" encoding="UTF-8"?>
<tileset name="Ground" tilewidth="35" tileheight="30" tilecount="5" columns="0">
 <terraintypes>
  <terrain name="Ground" tile="-1"/>
  <terrain name="Sky" tile="-1"/>
  <terrain name="New Terrain" tile="-1"/>
 </terraintypes>
 <tile id="0" terrain=",,0,0">
  <image width="35" height="30" source="Grass.png"/>
  <objectgroup draworder="index">
   <object id="4" x="0" y="0" width="35" visible="0"/>
  </objectgroup>
 </tile>
 <tile id="3" terrain="0,0,,">
  <image width="35" height="30" source="Dirt.png"/>
 </tile>
 <tile id="4">
  <image width="35" height="30" source="Sky.png"/>
 </tile>
 <tile id="5">
  <image width="35" height="30" source="Bedstone.png"/>
 </tile>
 <tile id="6">
  <image width="35" height="30" source="cobble.png"/>
 </tile>
</tileset>
