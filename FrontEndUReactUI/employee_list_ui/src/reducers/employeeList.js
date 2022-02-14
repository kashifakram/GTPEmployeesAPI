const employeeReducer = (state = [{id: 1, name: 'Kashif'}], action) => {
    switch (action.type) {
        case 'FETCHLIST':
            return state;
        case 'MODIFY':
            return modify(state, action.payload);
        default:
            return state;
    }
}

const modify = (state, id) => {
    return state.empR.filter(e => e.Id == id);
}


export default employeeReducer;