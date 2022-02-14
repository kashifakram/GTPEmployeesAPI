const employeeListAction = () => {return {type: 'FETCHLIST'};};
const employeeSingleAction = nr => {return {type: 'FETCHSINGLE', payload: nr};};
const employeeModifyAction = {type: 'MODIFY'};
const employeeCreateAction = {type: 'CREATE'};
const employeeDeleteAction = {type: 'DELETE'};

export default {
    employeeListAction, employeeSingleAction, employeeModifyAction, employeeCreateAction, employeeDeleteAction
}