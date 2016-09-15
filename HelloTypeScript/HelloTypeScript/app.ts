module app {
    export interface IGreet {
        greet() : void;
    }

    export class Greeter implements IGreet {
        private greeting: string;
        constructor(greeting: string) {
            this.greeting = greeting;
        }

        greet(): void {
            console.log(this.greeting);
            document.getElementById('content').textContent = this.greeting;
        }
    }
}

window.addEventListener('DOMContentLoaded',() => {
    var btn = document.getElementById('btnGreet');
    btn.addEventListener('click',() => {
        var name: string = (<HTMLInputElement>document.getElementById('txtName')).value;
        var greeter: app.IGreet = new app.Greeter("Hello, " + name);
        greeter.greet();
    });
});