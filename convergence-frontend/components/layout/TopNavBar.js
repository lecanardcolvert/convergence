import { useState } from 'react'
import { Menu } from 'semantic-ui-react'
import Image from "next/image"
import Link from "next/link"

export default function TopNavBar() {
    const [activeItem, setActiveItem] = useState("home")
    const handleItemClick = (e, { name }) => setActiveItem(name);

    return (
        <nav className="_top-nav-bar">
            <Menu size="large" stackable>
                <Menu.Item header>
                    <Image
                        src="/images/convergence-logo.png"
                        alt="Logo de Convergence"
                        width={32}
                        height={37.5}
                        unoptimized={true} />
                    &nbsp;&nbsp;&nbsp;
                    Convergence
                </Menu.Item>
                <Menu.Item
                    as={Link}
                    href="/"
                    name='home'
                    active={activeItem === 'home'}
                    onClick={handleItemClick}>
                    Accueil
                </Menu.Item>
                <Menu.Item
                    as={Link}
                    href="/events"
                    name='events'
                    active={activeItem === 'events'}
                    onClick={handleItemClick}>
                    Événements
                </Menu.Item>
            </Menu>
        </nav>
    )
}
