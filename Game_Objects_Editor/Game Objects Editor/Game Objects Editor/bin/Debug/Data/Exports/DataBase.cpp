#include "pch.h"
#include "DataBase.h"

//Method for acquiring Armor items by ID
ArmorComponent * DataBase::getArmor(int ID)
{
  for(auto i = armors.begin(); i != armors.end(); ++i)
      if(ID == i->getid())
          return i->copySelf();
  throw "404: not found";
  return nullptr;
}

//Method for acquiring Armor items by Name
ArmorComponent * DataBase::getArmor(string Name)
{
  for(auto i = armors.begin(); i!= armors.end(); ++i)
       if(Name == i->getname())
          return i->copySelf();
  throw "404: not found";
  return nullptr;
}

//Method for acquiring Weapon item by ID
WeaponComponent * DataBase::getWeapon(int ID)
{
  for(auto i = weapons.begin(); i!=weapons.end(); ++i) {
      if(ID == i->getid())
          return i->copySelf();
  }
  throw "404: not found";
  return nullptr;
}

//Method for acquiring Weapon item by Name
WeaponComponent * DataBase::getWeapon(string Name)
{
  for(auto i =weapons.begin(); i != weapons.end(); ++i) {
      if(Name == i->Getname())
          return i->copySelf();
  }
  throw "404: not found";
  return nullptr;
}
DataBase::~DataBase()
{
}
DataBase::DataBase()
{
//weapons.push_back(new WeaponComponent(Type, Name));
//weapons[id].spawn(element,amplitude,duration,damage,range,masteryReq,classReq,Description);

weapons.push_back(new WeaponComponent("Special","Null"));
weapons[0].spawn("Harmony",0,0,1,1,1,"Villain","The Null_Weapon");

weapons.push_back(new WeaponComponent("Halberd","Purple"));
weapons[1].spawn("Ice",1,3,1,1,1,"Villain","Wooow!");

//Populating Armors DataBase
//Buffs/Debuffs haven't been included yet.
armors.push_back(new ArmorComponent(null));
armors[0].spawn([<"Fire",0>,<"Ice",0>,<"Poison",0>,<"Dark",0>,<"Nature",0>,<"Wind",0>,<"Light",0>,<"Harmony",0>],false,Null Armor Object,[<"legs",false>,<"rightArm"false>,<"leftArm"false>,<"Head"false>],1,Villain,1,0);

armors.push_back(new ArmorComponent(Bag));
armors[0].spawn([<"Fire",11>,<"Ice",1>,<"Poison",3>,<"Dark",1>,<"Nature",1>,<"Wind",1>,<"Light",1>,<"Harmony",1>],false,,[<"legs",false>,<"rightArm"false>,<"leftArm"false>,<"Head"false>],1,Wizard,1,1);

}
