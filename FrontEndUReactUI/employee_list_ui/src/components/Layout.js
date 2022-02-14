import { Outlet, Link } from "react-router-dom";
import { BackButton } from "./BackButton";

const Layout = () => {
    return (
        <>
            <div>
                <div className="container mt-3">
                    <div className="mt-4 p-5 bg-light text-black rounded">
                        <BackButton />
                        <h2>Employees' list</h2>
                    </div>
                </div>
            </div>
            <Outlet />
        </>
    )
};

export default Layout;