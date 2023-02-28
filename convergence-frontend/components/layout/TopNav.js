import React, { Component } from 'react'
import { Menu } from 'semantic-ui-react'
import Image from "next/image"

export default class TopMenu extends Component {
    state = { activeItem: 'accueil' }

    handleItemClick = (e, { name }) => this.setState({ activeItem: name })

    render() {
        const { activeItem } = this.state

        return (
            <nav>
                <Menu size="large">
                    <Menu.Item header>
                        <Image
                            src="/images/convergence-logo.png"
                            alt="Logo de Convergence"
                            width={32}
                            height={32}
                            unoptimized={true} />
                        &nbsp;
                        Convergence
                    </Menu.Item>
                    <Menu.Item
                        name='accueil'
                        active={activeItem === 'accueil'}
                        onClick={this.handleItemClick}
                    />
                    <Menu.Item
                        name='événements'
                        active={activeItem === 'événements'}
                        onClick={this.handleItemClick}
                    />
                </Menu>
            </nav>
        )
    }
}
