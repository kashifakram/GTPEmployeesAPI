import React from 'react'

export default function Date({type}) {
    const typeDay = type && type === "start" ? "startDateDay" : "endDateDay";
    const typeMonth = type && type === "start" ? "startDateMonth" : "endDateMonth";
    const typeYear = type && type === "start" ? "startDateYear" : "endDateYear";
    
    return (
        <div className="row gy-2 gx-3 align-items-center">

            <div className="col-auto">
                <label className="visually-hidden" htmlFor={typeDay}>Day</label>
                <input type="text" className="form-control" id={typeDay} placeholder="" />
            </div>

            <div className="col-auto">
                <label className="visually-hidden" htmlFor={typeMonth}>Month</label>
                <select className="form-select" id={typeMonth}>
                    <option defaultValue>Choose...</option>
                    <option value="1">January</option>
                    <option value="2">February</option>
                    <option value="3">March</option>
                    <option value="4">April</option>
                    <option value="5">May</option>
                    <option value="6">June</option>
                    <option value="7">July</option>
                    <option value="8">August</option>
                    <option value="9">September</option>
                    <option value="10">October</option>
                    <option value="11">November</option>
                    <option value="12">December</option>
                </select>
            </div>

            <div className="col-auto">
                <label className="visually-hidden" htmlFor={typeYear}>Day</label>
                <input type="text" className="form-control" id={typeYear} placeholder="" />
            </div>

        </div>
    )
}
