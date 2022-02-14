import React from 'react'

export const List = () => {
    return (
        <div>
            <div className="container mt-5">
                <table className="table table-hover">
                    <thead>
                        <tr>
                            <th style={{width: "80%"}}>Please click on Edit to find more details about each employee.</th>
                            <th style={{width: "10%"}}><button type="button" className="btn btn-primary">Primary</button></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td style={{width: "80%"}}>Edit</td> | 
                            <td style={{width: "10%"}}>Remove</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    )
}
