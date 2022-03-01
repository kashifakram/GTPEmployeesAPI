import * as actionTypes from "../actions/types";

const employeeReducer = (state = [{id: 1, name: 'Kashif'}], action) => {
    switch (action.type) {
        case actionTypes.FETCHLIST:
            return state;
        case actionTypes.MODIFY:
            return modify(state, action.payload);
        default:
            return state;
    }
}

const modify = (state, id) => {
    return state.empR.filter(e => e.Id == id);
}


export default employeeReducer;