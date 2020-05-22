export default class BasePokemon {
    constructor(data) {
        this.id = data.id ? data.id : null;
        this.name = data.name
            ? data.name
            : '';
    }
}