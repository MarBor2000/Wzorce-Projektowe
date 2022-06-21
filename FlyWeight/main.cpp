#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;


class Texture {
public:
    int id;
    string color;
    Texture(int id, string color);
};

Texture::Texture(int id, string color) {
    this->id=id;
    this->color=color;
}


class Mob {
public:
    Mob(string name, Texture* texture);
private:
    string name;
    Texture* texture;
};

Mob::Mob(string name, Texture* texture) {
    this->name=name;
    this->texture=texture;
}


class TextureFactory {
private:
    vector<Texture*>* textures;
public:
    TextureFactory();
    Texture* createTex(int id, string color);
};

TextureFactory::TextureFactory() {
    this->textures = new vector<Texture*>();
}

Texture* TextureFactory::createTex(int id, string color) {
    this->textures->push_back(new Texture(id,color));
    return this->textures->back();
}


class Game {
public:
    Game(TextureFactory* textureFactory);
    void setMob(string name,Texture* texture);
private:
    TextureFactory* textureFactory;
    vector<Mob*>* mobs;
};


void Game::setMob(string name,Texture* texture) {
    Mob *xD=new Mob(name,texture);
    auto it =find(mobs->begin(), mobs->end(),xD);
    if(it != mobs->end()){
        cout<<"Mob with this name  "<<name<<" id "<<texture->id<<" and color "<<texture->color<<" exists\n";
    }
    //idk why this if not work
    else{
        mobs->push_back(new Mob(name,texture));
        cout<<"Create new mob "<< name<< " with id "<<texture->id<<" and color "<<texture->color<<endl;
    }


}

Game::Game(TextureFactory* textureFactory) {
    this->textureFactory=textureFactory;
    this->mobs = new vector<Mob*>();
}



int main()
{
    TextureFactory* fac = new TextureFactory();
    Game *game = new Game(fac);

    Texture* tx = fac->createTex(01,"000000");
    Texture* tx1 = fac->createTex(02,"ffffff");
    game->setMob("Ork",tx1);
    game->setMob("Wampir",tx);
    game->setMob("Ork",tx1);
    return 0;
}
