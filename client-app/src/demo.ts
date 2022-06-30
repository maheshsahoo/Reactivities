let data:any=43;

data='42';

interface IDuck
{
    name:string,
    numlegs:number,
  //  makeSound?:(sound:string) => void;
  makeSound:(sound:string) => void;
}

const duck1:IDuck={
    name:'huey',
    numlegs:2,
    makeSound:(sound:any)=> console.log(sound)
}

const duck2:IDuck={
    name:'dewey',
    numlegs:2,
  //  makeSound:(sound:any)=> console.log(sound)
  makeSound:(sound:any)=> console.log(sound)
}

//duck1.makeSound!('quack');
duck1.makeSound('quack');

export const ducks=[duck1,duck2];